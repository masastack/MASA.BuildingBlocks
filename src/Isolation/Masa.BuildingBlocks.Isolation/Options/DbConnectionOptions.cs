namespace Masa.BuildingBlocks.Isolation.Options;
public class DbConnectionOptions
{
    public string TenantId { get; set; } = "";

    public string Environment { get; set; } = "";

    public string ConnectionString { get; set; }
}
