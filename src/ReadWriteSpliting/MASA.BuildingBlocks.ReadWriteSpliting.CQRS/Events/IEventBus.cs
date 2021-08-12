namespace MASA.BuildingBlocks.ReadWriteSpliting.CQRS.Events
{
    public interface IEventBus
    {
        Task PublishAsync<TEvent>(TEvent @event)
            where TEvent : Event;
    }
}
