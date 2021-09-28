using Microsoft.Extensions.DependencyInjection;

namespace MASA.BuildingBlocks.Dispatcher.Events;
public interface IDispatcherOptions
{
    IServiceCollection Services {  get; }
}
