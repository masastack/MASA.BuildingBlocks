﻿namespace MASA.Contrib.Dispatcher.IntegrationEvents.Dapr.Internal;

/// <summary>
/// Use the local queue to retry sending failed messages
/// </summary>
internal class IntegrationEventLogItem
{
    public Guid EventId { get; }

    public string Topic { get; }

    public DateTime CreationTime { get; }

    public int RetryCount { get; private set; }

    public object Event { get; }

    public IntegrationEventLogItem(Guid eventId, string topic, object @event)
    {
        EventId = eventId;
        Topic = topic;
        RetryCount = 0;
        CreationTime = DateTime.UtcNow;
        Event = @event;
    }

    public void Retry()
    {
        this.RetryCount++;
    }
}
