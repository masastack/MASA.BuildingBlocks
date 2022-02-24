namespace Masa.BuildingBlocks.Ddd.Domain.Events;
public interface IDomainQuery<TResult> : IDomainEvent, IQuery<TResult>
    where TResult : notnull
{

}
