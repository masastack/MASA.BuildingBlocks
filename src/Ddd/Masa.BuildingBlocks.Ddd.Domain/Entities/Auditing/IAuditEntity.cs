namespace Masa.BuildingBlocks.Ddd.Domain.Entities.Auditing;
public interface IAuditEntity<TUserId> : ISoftDelete
{
    TUserId Creator { get; }

    DateTime CreationTime { get; }

    TUserId Modifier { get; }

    DateTime ModificationTime { get; }
}
