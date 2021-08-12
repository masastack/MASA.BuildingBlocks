using MASA.BuildingBlocks.ReadWriteSpliting.CQRS.Events;

namespace MASA.BuildingBlocks.ReadWriteSpliting.CQRS.Abstractions
{
    public interface IIntegrationEventBus
    {
        Task PublishAsync<TEvent>(TEvent @event)
            where TEvent : IntegrationEvent;
    }
}
