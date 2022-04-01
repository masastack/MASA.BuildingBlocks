namespace Masa.BuildingBlocks.Isolation;

public interface IParserProvider
{
    string Name { get; }

    Task<bool> ResolveAsync(IServiceProvider serviceProvider, string key, Action<string> action);
}
