namespace Masa.BuildingBlocks.Data.UoW;
public abstract class BaseDataConnectionStringProvider : IDataConnectionStringProvider
{
    private readonly List<MasaDbContextConfigurationOptions>? _dbContextOptionsList = null;

    public virtual List<MasaDbContextConfigurationOptions> DbContextOptionsList => _dbContextOptionsList ?? GetDbContextOptionsList();

    protected abstract List<MasaDbContextConfigurationOptions> GetDbContextOptionsList();
}
