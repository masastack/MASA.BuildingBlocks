namespace Masa.BuildingBlocks.Isolation;
public interface ITenantParserProvider
{
    string Name { get;}

    Task<bool> ResolveAsync(IServiceProvider serviceProvider);
}
