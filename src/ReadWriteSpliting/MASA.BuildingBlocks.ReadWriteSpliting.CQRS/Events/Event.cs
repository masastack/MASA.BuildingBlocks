namespace MASA.BuildingBlocks.ReadWriteSpliting.CQRS.Events
{
    public class Event
    {
        public Guid Id { get; private set; }

        public DateTime CreationTime { get; private set; }
    }
}
