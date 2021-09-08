namespace MASA.BuildingBlocks.Service.MinimalAPIs;
public interface IService
{
    IServiceCollection Services { get; }

    TService? GetService<TService>();

    TService GetRequiredService<TService>() where TService : notnull;
}
