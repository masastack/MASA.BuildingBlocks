namespace MASA.BuildingBlocks.DDD.Domain.Events
{
    public interface IDomainEventBus
    {
        Task PublishAsync<TDomentEvent>(TDomentEvent @event)
            where TDomentEvent : IDomainEvent;

        Task Enqueue<TDomentEvent>(TDomentEvent @event)
            where TDomentEvent : IDomainEvent;

        Task PublishQueueAsync();
    }
}
