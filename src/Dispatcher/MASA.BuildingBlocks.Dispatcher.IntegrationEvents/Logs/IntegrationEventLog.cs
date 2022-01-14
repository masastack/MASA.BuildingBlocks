namespace MASA.BuildingBlocks.Dispatcher.IntegrationEvents.Logs;
public class IntegrationEventLog
{
    public Guid Id { get; private set; }

    public Guid EventId { get; private set; }

    public string EventTypeName { get; private set; } = null!;

    [NotMapped] public string EventTypeShortName => EventTypeName.Split('.').Last();

    [NotMapped] public IIntegrationEvent Event { get; private set; } = null!;

    public IntegrationEventStates State { get; set; }

    public int TimesSent { get; set; }

    public DateTime CreationTime { get; private set; }

    public DateTime? NextRetryTime { get; set; }

    public string Content { get; private set; } = null!;

    public Guid TransactionId { get; private set; } = Guid.Empty;

    private IntegrationEventLog()
    {
        Id = Guid.NewGuid();
        State = IntegrationEventStates.NotPublished;
        TimesSent = 0;
    }

    public IntegrationEventLog(IIntegrationEvent @event, Guid transactionId) : this()
    {
        EventId = @event.Id;
        CreationTime = @event.CreationTime;
        EventTypeName = @event.GetType().FullName!;
        Content = System.Text.Json.JsonSerializer.Serialize((object) @event);
        TransactionId = transactionId;
    }

    public IntegrationEventLog DeserializeJsonContent(Type type)
    {
        Event = (System.Text.Json.JsonSerializer.Deserialize(Content, type) as IIntegrationEvent)!;
        return this;
    }
}
