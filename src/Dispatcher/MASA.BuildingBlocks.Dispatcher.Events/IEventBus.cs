namespace MASA.BuildingBlocks.Dispatcher.Events;
public interface IEventBus
{
    Task PublishAsync<TEvent>(TEvent @event)
        where TEvent : IEvent;

    IEnumerable<Type> GetAllEventTypes();
}
