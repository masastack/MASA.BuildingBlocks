namespace MASA.BuildingBlocks.Data.Uow;
public interface ITransaction
{
    [JsonIgnore]
    IUnitOfWork UnitOfWork { get; set; }
}
