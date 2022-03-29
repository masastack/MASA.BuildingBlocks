namespace Masa.BuildingBlocks.Data.UoW;
public interface IUnitOfWorkAccessor
{
    /// <summary>
    /// Only exists when a new DbContext is created through IUnitOfWorkManager or after IUnitOfWork is obtained
    /// </summary>
    MasaDbContextConfigurationOptions? CurrentDbContextOptions { get; set; }
}
