﻿namespace MASA.Contrib.Dispatcher.IntegrationEvents.Dapr.Processor;

public class RetryByDataProcessor : ProcessorBase
{
    private readonly IServiceProvider _serviceProvider;
    private readonly IOptions<DispatcherOptions> _options;
    private readonly IOptionsMonitor<AppConfig> _appConfig;
    private readonly ILogger<RetryByDataProcessor>? _logger;

    public RetryByDataProcessor(
        IServiceProvider serviceProvider,
        IOptionsMonitor<AppConfig> appConfig,
        IOptions<DispatcherOptions> options,
        ILogger<RetryByDataProcessor>? logger = null)
    {
        _serviceProvider = serviceProvider;
        _appConfig = appConfig;
        _options = options;
        _logger = logger;
    }

    public override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        using (var scope = _serviceProvider.CreateScope())
        {
            var unitOfWork = scope.ServiceProvider.GetService<IUnitOfWork>();
            if (unitOfWork != null)
                unitOfWork.UseTransaction = false;

            var dapr = _serviceProvider.GetRequiredService<DaprClient>();
            var eventLogService = scope.ServiceProvider.GetRequiredService<IIntegrationEventLogService>();

            var retrieveEventLogs =
                await eventLogService.RetrieveEventLogsFailedToPublishAsync(_options.Value.RetryBatchSize, _options.Value.MaxRetryTimes, _options.Value.MinimumRetryInterval);

            foreach (var eventLog in retrieveEventLogs)
            {
                try
                {
                    if (LocalQueueProcessor.Default.IsExist(eventLog.EventId))
                        continue; // The local queue is retrying, no need to retry

                    await eventLogService.MarkEventAsInProgressAsync(eventLog.EventId);

                    _logger?.LogDebug("Publishing integration event {Event} to {PubsubName}.{TopicName}", eventLog,
                        _options.Value.PubSubName,
                        eventLog.Event.Topic);

                    await dapr.PublishEventAsync(_options.Value.PubSubName, eventLog.Event.Topic, eventLog.Event, stoppingToken);

                    LocalQueueProcessor.Default.RemoveJobs(eventLog.EventId);

                    await eventLogService.MarkEventAsPublishedAsync(eventLog.EventId);
                }
                catch (UserFriendlyException)
                {
                    //Update state due to multitasking contention, no processing required
                }
                catch (Exception ex)
                {
                    _logger?.LogError(ex,
                        "Error Publishing integration event: {IntegrationEventId} from {AppId} - ({IntegrationEvent})",
                        eventLog.EventId, _appConfig.CurrentValue.AppId, eventLog);
                    await eventLogService.MarkEventAsFailedAsync(eventLog.EventId);
                }
                finally
                {
                    if (unitOfWork != null && unitOfWork.TransactionHasBegun)
                        await unitOfWork.CommitAsync(stoppingToken);
                }
            }
        }
    }

    public override int Delay => _options.Value.FailedRetryInterval;
}
