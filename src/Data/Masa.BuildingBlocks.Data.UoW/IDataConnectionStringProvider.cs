namespace Masa.BuildingBlocks.Data.UoW;
public interface IDataConnectionStringProvider
{
    List<MasaDbContextConfigurationOptions> DbContextOptionsList { get; }
}
