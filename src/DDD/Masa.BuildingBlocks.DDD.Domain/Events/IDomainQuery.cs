namespace Masa.BuildingBlocks.DDD.Domain.Events;
public interface IDomainQuery<TResult> : IDomainEvent, IQuery<TResult>
    where TResult : notnull
{

}
