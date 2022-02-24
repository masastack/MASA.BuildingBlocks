namespace Masa.BuildingBlocks.Ddd.Domain.Entities;
public abstract class AggregateRoot : Entity, IAggregateRoot
{

}

public class AggregateRoot<TKey> : Entity<TKey>, IAggregateRoot<TKey>
{

}
