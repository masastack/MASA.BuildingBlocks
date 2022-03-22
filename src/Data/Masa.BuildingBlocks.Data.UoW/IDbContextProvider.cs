namespace Masa.BuildingBlocks.Data.UoW;

public interface IDbContextProvider
{
    DbContextOptions? CurrentDbContextOption { get; }

    List<DbContextOptions> DbContextOptionsList { get;  }

    bool ChangeDbContext(DbContextOptions dbContextOptions);
}
