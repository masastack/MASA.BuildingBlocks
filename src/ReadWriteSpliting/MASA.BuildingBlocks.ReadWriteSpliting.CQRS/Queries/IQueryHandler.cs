namespace MASA.BuildingBlocks.ReadWriteSpliting.CQRS.Queries;

public interface IQueryHandler<TCommand> : IEventHandler<TCommand>
    where TCommand : IQuery
{
}