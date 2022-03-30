namespace Masa.BuildingBlocks.Data.UoW;
public interface IDbConnectionStringProvider
{
    List<MasaDbContextConfigurationOptions> DbContextOptionsList { get; }
}
