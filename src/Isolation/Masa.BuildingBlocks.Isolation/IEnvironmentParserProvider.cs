namespace Masa.BuildingBlocks.Isolation;
public interface IEnvironmentParserProvider
{
    string Name { get;}

    Task<bool> ResolveAsync(IServiceProvider serviceProvider);
}
