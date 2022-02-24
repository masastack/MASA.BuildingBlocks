namespace Masa.BuildingBlocks.Ddd.Domain.Entities.Auditing;
public interface IAuditEntity<TUserId> : ISoftDelete
{
    TUserId Creator { get; set; }

    DateTime CreationTime { get; set; }

    TUserId Modifier { get; set; }

    DateTime ModificationTime { get; set; }
}
