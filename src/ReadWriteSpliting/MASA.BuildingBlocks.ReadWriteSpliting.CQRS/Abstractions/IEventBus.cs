using MASA.BuildingBlocks.ReadWriteSpliting.CQRS.Events;

namespace MASA.BuildingBlocks.ReadWriteSpliting.CQRS.Abstractions
{
    public interface IEventBus
    {
        Task PublishAsync<TEvent>(TEvent @event)
            where TEvent : Event;
    }
}
