namespace MASA.BuildingBlocks.DDD.Domain.Events
{
    public interface IIntegrationDomainEvent : IDomainEvent
    {
        public string Topic { get; set; }
    }
}
