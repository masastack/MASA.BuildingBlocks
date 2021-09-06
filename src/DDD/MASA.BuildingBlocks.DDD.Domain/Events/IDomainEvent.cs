namespace MASA.BuildingBlocks.DDD.Domain.Events
{
    public interface IDomainEvent
    {
        EventTypes Type { get; set; }

        IEvent Event { get; set; }

        IntegrationEvent IntegrationEvent { get; set; }
    }
}
