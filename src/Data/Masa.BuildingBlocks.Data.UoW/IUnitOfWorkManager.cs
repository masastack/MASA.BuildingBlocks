namespace Masa.BuildingBlocks.Data.UoW;

public interface IUnitOfWorkManager
{
    /// <summary>
    ///
    /// </summary>
    /// <param name="lazyLoading">Deferred creation of DbContext, easy to specify tenant or environment by yourself, which is very effective for physical isolation</param>
    /// <returns></returns>
    IUnitOfWork CreateDbContext(bool lazyLoading = true);

    IUnitOfWork CreateDbContext(MasaDbContextConfigurationOptions dbContextOptions);
}
