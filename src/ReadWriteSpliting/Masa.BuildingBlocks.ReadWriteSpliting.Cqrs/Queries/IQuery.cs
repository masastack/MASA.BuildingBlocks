namespace Masa.BuildingBlocks.ReadWriteSpliting.Cqrs.Queries;
public interface IQuery<TResult> : IEvent<TResult>
    where TResult : notnull
{
}
