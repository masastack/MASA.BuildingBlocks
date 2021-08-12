namespace MASA.BuildingBlocks.ReadWriteSpliting.CQRS.Events
{
    public class IntegrationEvent : Event
    {
        public string? Topic { get; set; } = null;
    }
}
