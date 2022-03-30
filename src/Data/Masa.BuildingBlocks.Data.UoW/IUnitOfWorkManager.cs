namespace Masa.BuildingBlocks.Data.UoW;
public interface IUnitOfWorkManager
{
    IUnitOfWork CreateDbContext();

    IUnitOfWork CreateDbContext(MasaDbContextConfigurationOptions dbContextOptions);
}
