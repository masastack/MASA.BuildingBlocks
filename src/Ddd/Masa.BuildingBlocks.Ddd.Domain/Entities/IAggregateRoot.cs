namespace Masa.BuildingBlocks.Ddd.Domain.Entities;
public interface IAggregateRoot : IEntity
{

}

public interface IAggregateRoot<TKey> : IEntity<TKey>, IAggregateRoot
{

}
