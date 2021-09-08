namespace MASA.BuildingBlocks.Dispatcher.Remoting;
public interface IIntegrationEventBus
{
    Task PublishAsync<TEvent>(TEvent @event)
        where TEvent : IIntegrationEvent;

    Task PublishAsync<TEvent>(TEvent @event, DbTransaction transaction)
        where TEvent : IIntegrationEvent;
}
