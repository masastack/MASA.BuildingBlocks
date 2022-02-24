namespace Masa.BuildingBlocks.Ddd.Domain.Events;
public interface IDomainEventBus : IEventBus
{
    Task Enqueue<TDomentEvent>(TDomentEvent @event)
        where TDomentEvent : IDomainEvent;

    Task PublishQueueAsync();
}
