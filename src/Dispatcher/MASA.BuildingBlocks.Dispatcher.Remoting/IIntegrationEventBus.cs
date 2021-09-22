namespace MASA.BuildingBlocks.Dispatcher.Remoting;
public interface IIntegrationEventBus
{
    Task PublishAsync<TEvent>(TEvent @event)
        where TEvent : IIntegrationEvent;
}
