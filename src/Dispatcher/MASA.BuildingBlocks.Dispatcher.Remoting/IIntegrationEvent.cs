namespace MASA.BuildingBlocks.Dispatcher.Remoting;
public interface IIntegrationEvent
{
    Guid Id { get; }

    DateTime CreationTime { get; }

    public string Topic { get; set; }
}
