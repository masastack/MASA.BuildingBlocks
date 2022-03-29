namespace Masa.BuildingBlocks.Ddd.Domain.Entities.Auditing;
public interface IAuditEntity<TUserId>
{
    TUserId Creator { get; }

    DateTime CreationTime { get; }

    TUserId Modifier { get; }

    DateTime ModificationTime { get; }
}
