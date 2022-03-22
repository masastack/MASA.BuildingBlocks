namespace Masa.BuildingBlocks.Dispatcher.Events;

public delegate Task EventHandlerDelegate();

/// <summary>
/// Middleware is assembled into an event pipeline to handle invoke event and result
/// </summary>
public interface IMiddleware<TEvent> where TEvent : IEvent
{
    Task HandleAsync(TEvent @event, EventHandlerDelegate next);
}
