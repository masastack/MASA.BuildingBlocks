namespace MASA.BuildingBlocks.Dispatcher.InMemory;
public interface IEventHandler<TEvent>
        where TEvent : IEvent
{
    Task HandleAsync(TEvent @event);
}