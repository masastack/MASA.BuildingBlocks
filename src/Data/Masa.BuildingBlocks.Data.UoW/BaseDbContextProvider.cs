namespace Masa.BuildingBlocks.Data.UoW;
public abstract class BaseDbContextProvider : IDbContextProvider
{
    private readonly AsyncLocal<DbContextOptions?> _currentDbContextOption = new();

    public virtual DbContextOptions? CurrentDbContextOption
    {
        get => _currentDbContextOption.Value;
        private set => _currentDbContextOption.Value = value;
    }

    private readonly List<DbContextOptions>? _dbContextOptionsList = null;

    public virtual List<DbContextOptions> DbContextOptionsList => _dbContextOptionsList ?? GetDbContextOptionsList();

    public virtual bool ChangeDbContext(DbContextOptions dbContextOptions)
    {
        CurrentDbContextOption = dbContextOptions;
        return true;
    }

    protected abstract List<DbContextOptions> GetDbContextOptionsList();
}
