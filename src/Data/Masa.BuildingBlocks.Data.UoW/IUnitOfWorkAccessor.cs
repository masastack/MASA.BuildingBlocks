namespace Masa.BuildingBlocks.Data.UoW;
public interface IUnitOfWorkAccessor
{
    /// <summary>
    /// Only exists after the DbContext is confirmed to be created
    /// </summary>
    MasaDbContextConfigurationOptions? CurrentDbContextOptions { get; set; }
}
