namespace MASA.BuildingBlocks.Data.Uow;
public interface ITransaction
{
    DbTransaction Transaction { get; set; }
}
