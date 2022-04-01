namespace Masa.BuildingBlocks.Data.UoW.Options;
public class MasaDbContextConfigurationOptions
{
    public string ConnectionString { get; }

    public MasaDbContextConfigurationOptions(string connectionString) => ConnectionString = connectionString;
}
