namespace Masa.BuildingBlocks.Data.UoW;
public abstract class BaseDataConnectionStringProvider : IDataConnectionStringProvider
{
    private readonly List<MasaDbContextOptions>? _dbContextOptionsList = null;

    public virtual List<MasaDbContextOptions> DbContextOptionsList => _dbContextOptionsList ?? GetDbContextOptionsList();

    protected abstract List<MasaDbContextOptions> GetDbContextOptionsList();
}
