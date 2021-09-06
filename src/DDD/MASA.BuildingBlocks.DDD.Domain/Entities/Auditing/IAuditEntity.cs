namespace MASA.BuildingBlocks.DDD.Domain.Entities.Auditing
{
    public interface IAuditEntity<TUserId>
    {
        bool IsDeleted { get; set; }

        TUserId Creator { get; set; }

        DateTime CreationTime { get; set; }

        TUserId Modifier { get; set; }

        DateTime ModificationTime { get; set; }
    }
}
