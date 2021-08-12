namespace MASA.BuildingBlocks.ReadWriteSpliting.CQRS.IntegrationEvents
{
    public class IntegrationEvent : Event
    {
        public string? Topic { get; set; } = null;
    }
}
