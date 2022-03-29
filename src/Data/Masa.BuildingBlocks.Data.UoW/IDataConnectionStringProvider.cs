namespace Masa.BuildingBlocks.Data.UoW;
public interface IDataConnectionStringProvider
{
    List<MasaDbContextOptions> DbContextOptionsList { get; }
}
