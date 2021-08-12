namespace MASA.BuildingBlocks.ReadWriteSpliting.CQRS.EventLogs
{
    public enum IntegrationEventStates
    {
        NotPublished = 0,
        InProgress = 1,
        Published = 2,
        PublishedFailed = 3
    }
}
