namespace Masa.BuildingBlocks.Isolation;
public interface IIsolationDbConnectionStringProvider
{
    Task<string> GetConnectionStringAsync();

    string GetConnectionString();
}
