namespace MASA.BuildingBlocks.Dispatcher.Remoting;

public class IntegrationEvent : Event
{
    public string? Topic { get; set; } = null;
}
