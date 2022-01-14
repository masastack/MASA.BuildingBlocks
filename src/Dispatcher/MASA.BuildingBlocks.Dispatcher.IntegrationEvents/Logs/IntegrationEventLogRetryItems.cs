﻿namespace MASA.BuildingBlocks.Dispatcher.IntegrationEvents.Logs;
/// <summary>
/// Local message retry logging
/// </summary>
public class IntegrationEventLogRetryItems
{
    public Guid Id { get; private set; }

    public Guid LogId { get; private set; }

    public DateTime CreationTime { get; private set; }

    public int RetryTimes { get; private set; }

    private IntegrationEventLogRetryItems()
    {
        Id = Guid.NewGuid();
        CreationTime = DateTime.Now;
    }

    public IntegrationEventLogRetryItems(Guid logId, int retryTimes)
    {
        LogId = logId;
        RetryTimes = retryTimes;
    }
}
