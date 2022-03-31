namespace Masa.BuildingBlocks.Isolation.Options;
public class IsolationDbConnectionOptions
{
    public string DefaultConnection { get; set; }

    public List<DbConnectionOptions> Isolations { get; set; } = new();
}
