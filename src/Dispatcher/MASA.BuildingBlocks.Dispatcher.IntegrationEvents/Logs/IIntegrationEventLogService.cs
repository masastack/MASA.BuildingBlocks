namespace MASA.BuildingBlocks.Dispatcher.IntegrationEvents.Logs;

public interface IIntegrationEventLogService
{
    /// <summary>
    /// Get messages to retry
    /// </summary>
    /// <param name="retryBatchSize">The size of a single event to be retried</param>
    /// <param name="maxRetryTimes"></param>
    /// <returns></returns>
    Task<IEnumerable<IntegrationEventLog>> RetrieveEventLogsFailedToPublishAsync(int retryBatchSize,int maxRetryTimes);

    Task SaveEventAsync(IIntegrationEvent @event, DbTransaction transaction);

    Task MarkEventAsPublishedAsync(Guid eventId);

    Task MarkEventAsInProgressAsync(Guid eventId);

    Task MarkEventAsFailedAsync(Guid eventId);

    /// <summary>
    /// Delete successfully published and expired data
    /// </summary>
    /// <param name="timeout">expire date</param>
    /// <param name="batchCount"></param>
    /// <param name="token"></param>
    /// <returns></returns>
    Task DeleteExpiresAsync(DateTime timeout, int batchCount = 1000, CancellationToken token = default);
}
