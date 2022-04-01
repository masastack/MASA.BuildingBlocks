namespace Masa.BuildingBlocks.Isolation.Middleware;

public interface IIsolationMiddleware
{
    Task HandleAsync();
}
