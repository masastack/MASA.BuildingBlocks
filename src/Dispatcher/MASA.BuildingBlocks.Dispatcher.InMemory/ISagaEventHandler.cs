namespace MASA.BuildingBlocks.Dispatcher.InMemory;
public interface ISagaEventHandler<TEvent> : IEventHandler<TEvent>
        where TEvent : IEvent
{
    Task CancelAsync(TEvent @event);
}