namespace MASA.BuildingBlocks.ReadWriteSpliting.CQRS.IntegrationEvents
{
    public enum IntegrationEventStates
    {
        NotPublished = 0,
        InProgress = 1,
        Published = 2,
        PublishedFailed = 3
    }
}
