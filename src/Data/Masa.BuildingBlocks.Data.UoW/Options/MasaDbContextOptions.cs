namespace Masa.BuildingBlocks.Data.UoW.Options;
public class MasaDbContextOptions
{
    public string ConnectionString { get; }

    public DbConnection? Connection { get; }

    public MasaDbContextOptions(string connectionString) => ConnectionString = connectionString;

    public MasaDbContextOptions(DbConnection connection) : this(connection.ConnectionString) => Connection = connection;
}
