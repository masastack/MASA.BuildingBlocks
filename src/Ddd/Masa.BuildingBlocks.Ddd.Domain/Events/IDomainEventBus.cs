namespace Masa.BuildingBlocks.Ddd.Domain.Events;
public interface IDomainEventBus : IEventBus
{
    Task Enqueue<TDomainEvent>(TDomainEvent @event)
        where TDomainEvent : IDomainEvent;

    Task PublishQueueAsync();
}
