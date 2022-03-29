namespace Masa.BuildingBlocks.Data.UoW;
public interface IUnitOfWorkManager
{
    Task<IUnitOfWork> CreateDbContextAsync(MasaDbContextOptions dbContextOptions);
}
