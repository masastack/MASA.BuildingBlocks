namespace MASA.BuildingBlocks.Dispatcher.Remoting;
public interface IIntegrationEvent : ITransaction
{
    Guid Id { get; }

    DateTime CreationTime { get; }

    public string Topic { get; set; }
}
