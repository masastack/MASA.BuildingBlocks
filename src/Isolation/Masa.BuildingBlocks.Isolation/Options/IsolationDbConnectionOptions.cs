namespace Masa.BuildingBlocks.Isolation.Options;
public class IsolationDbConnectionOptions
{
    public string DefaultConnection { get; set; }

    public List<DbConnectionOptions> ConnectionStrings { get; set; } = new();
}
