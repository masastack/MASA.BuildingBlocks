namespace MASA.BuildingBlocks.ReadWriteSpliting.CQRS.Events
{
    public class Event
    {
        public Guid Id { get; private set; } = Guid.NewGuid();

        public DateTime CreationTime { get; private set; } = DateTime.Now;
    }
}
