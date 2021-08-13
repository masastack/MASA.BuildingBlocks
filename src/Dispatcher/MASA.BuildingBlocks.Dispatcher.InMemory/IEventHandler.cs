namespace MASA.BuildingBlocks.Dispatcher.InMemory
{
    public interface IEventHandler<TEvent>
        where TEvent : Event
    {
        Task HandleAsync(TEvent @event);
    }
}
