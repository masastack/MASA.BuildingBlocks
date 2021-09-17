namespace MASA.BuildingBlocks.Service.MinimalAPIs;
public interface IService
{
    static WebApplication App { get; } = default!;

    IServiceCollection Services { get; }

    TService? GetService<TService>();

    TService GetRequiredService<TService>() where TService : notnull;
}
