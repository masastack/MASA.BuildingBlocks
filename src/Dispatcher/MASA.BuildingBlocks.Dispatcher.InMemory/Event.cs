namespace MASA.BuildingBlocks.Dispatcher.InMemory
{
    public class Event
    {
        public Guid Id { get; private set; } = Guid.NewGuid();

        public DateTime CreationTime { get; private set; } = DateTime.Now;
    }
}
