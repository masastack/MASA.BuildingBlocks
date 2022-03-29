namespace Masa.BuildingBlocks.Data.UoW;
public interface IUnitOfWorkManager
{
    Task<IUnitOfWork> CreateDbContextAsync();

    Task<IUnitOfWork> CreateDbContextAsync(MasaDbContextConfigurationOptions dbContextOptions);
}
