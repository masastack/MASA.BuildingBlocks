namespace MASA.BuildingBlocks.DDD.Domain.Entities.Auditing;
public abstract class AuditEntity<TUserId> : Entity, IAuditEntity<TUserId>
{
    public bool IsDeleted { get; set; }

    public TUserId Creator { get; set; } = default!;

    public DateTime CreationTime { get; set; } = DateTime.Now;

    public TUserId Modifier { get; set; } = default!;

    public DateTime ModificationTime { get; set; } = DateTime.Now;
}

public class AuditEntity<TKey, TUserId> : Entity<TKey>, IAuditEntity<TUserId>
{
    public bool IsDeleted { get; set; }

    public TUserId Creator { get; set; } = default!;

    public DateTime CreationTime { get; set; } = DateTime.Now;

    public TUserId Modifier { get; set; } = default!;

    public DateTime ModificationTime { get; set; } = DateTime.Now;
}
