namespace MASA.BuildingBlocks.Dispatcher.InMemory;

public delegate Task EventHandlerDelegate();

/// <summary>
/// Middleware is assembled into an event pipeline to handle invoke event and result
/// </summary>
public interface IMiddleware<TEvent, TResult>
    where TEvent : notnull
{
    Task<TResult> HandleAsync(TEvent @event, EventHandlerDelegate next);
}
