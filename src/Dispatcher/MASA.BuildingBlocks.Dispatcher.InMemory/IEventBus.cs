namespace MASA.BuildingBlocks.Dispatcher.InMemory;

public interface IEventBus
{
    Task PublishAsync<TEvent>(TEvent @event)
        where TEvent : IEvent;
}
