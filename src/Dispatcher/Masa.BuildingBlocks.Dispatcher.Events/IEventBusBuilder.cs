namespace Masa.BuildingBlocks.Dispatcher.Events;
public interface IEventBusBuilder
{
    public IServiceCollection Services { get; }

    IEventBusBuilder UseMiddleware(Type middleware, ServiceLifetime middlewareLifetime = ServiceLifetime.Transient);
}
