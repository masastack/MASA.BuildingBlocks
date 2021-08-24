namespace MASA.BuildingBlocks.Dispatcher.Remoting;
public class Event
{
    public Guid Id { get; private set; } = Guid.NewGuid();

    public DateTime CreationTime { get; private set; } = DateTime.Now;
}
