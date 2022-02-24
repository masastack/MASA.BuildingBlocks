namespace Masa.BuildingBlocks.Ddd.Domain.Entities.Auditing;
public abstract class AuditAggregateRoot<TUserId> : AuditEntity<TUserId>, IAggregateRoot
{

}

public class AuditAggregateRoot<TKey, TUserId> : AuditEntity<TKey, TUserId>, IAggregateRoot<TKey>
{

}
