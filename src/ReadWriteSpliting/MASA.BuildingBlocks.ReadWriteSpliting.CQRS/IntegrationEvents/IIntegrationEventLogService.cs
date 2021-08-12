namespace MASA.BuildingBlocks.ReadWriteSpliting.CQRS.IntegrationEvents
{
    public interface IIntegrationEventLogService
    {
        Task<IEnumerable<IntegrationEventLog>> RetrieveEventLogsPendingToPublishAsync(Guid transactionId);

        Task SaveEventAsync(IntegrationEvent @event, DbTransaction transaction);

        Task MarkEventAsPublishedAsync(Guid eventId);

        Task MarkEventAsInProgressAsync(Guid eventId);

        Task MarkEventAsFailedAsync(Guid eventId);
    }
}
