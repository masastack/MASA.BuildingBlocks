namespace MASA.BuildingBlocks.DDD.Domain.Events
{
    public interface IDomainEvent
    {
        public Guid Id { get; set; }

        public DateTime CreationTime { get; set; }
    }
}
