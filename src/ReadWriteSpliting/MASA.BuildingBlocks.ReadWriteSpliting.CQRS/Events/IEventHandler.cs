namespace MASA.BuildingBlocks.ReadWriteSpliting.CQRS.Events
{
    public interface IEventHandler<TEvent>
        where TEvent : Event
    {
        Task HandleAsync(TEvent @event);
    }
}
