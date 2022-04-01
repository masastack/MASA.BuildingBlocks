namespace Masa.BuildingBlocks.Isolation.Options;
public class DbConnectionOptions
{
    public string TenantId { get; set; }

    public string Environment { get; set; }

    public string ConnectionString { get; set; }

    /// <summary>
    /// Used to control the configuration with the highest score when multiple configurations are satisfied. The default score is 100
    /// </summary>
    public int Score { get; set; } = 100;
}
