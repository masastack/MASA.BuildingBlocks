namespace Masa.BuildingBlocks.Isolation;

public interface ITenantParserProvider
{
    string Name { get;}

    Task<bool> ExecuteAsync(IServiceProvider serviceProvider);
}
