namespace MASA.BuildingBlocks.DDD.Domain.Events
{
    public interface IDomainEventBus
    {
        Task PublishAsync<TDomentEvent>(TDomentEvent @event)
            where TDomentEvent : IDomainEvent;
    }
}
