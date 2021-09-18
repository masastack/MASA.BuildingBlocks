namespace MASA.BuildingBlocks.Dispatcher.InMemory;
public interface ITransactionalEvent : IEvent
{
    IUnitOfWork Uow { get; set; }
}
