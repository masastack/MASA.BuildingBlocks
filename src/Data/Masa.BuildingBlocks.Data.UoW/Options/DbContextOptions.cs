namespace Masa.BuildingBlocks.Data.UoW.Options;

public class DbContextOptions
{
    private DbConnection? _dbConnection;

    public string ConnectionString { get; }

    public DbConnection? ConnectionConnection
    {
        get
        {
            if (string.IsNullOrEmpty(ConnectionString))
                return _dbConnection;

            _dbConnection = new SqlConnection(ConnectionString);
            return _dbConnection;
        }
    }

    public DbContextOptions(string connectionString)
    {
        ConnectionString = connectionString;
    }
}
