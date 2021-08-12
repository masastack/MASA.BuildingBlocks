namespace MASA.BuildingBlocks.ReadWriteSpliting.CQRS.IntegrationEvents
{
    public interface IIntegrationEventBus
    {
        Task PublishAsync<TEvent>(TEvent @event)
            where TEvent : IntegrationEvent;
    }
}
