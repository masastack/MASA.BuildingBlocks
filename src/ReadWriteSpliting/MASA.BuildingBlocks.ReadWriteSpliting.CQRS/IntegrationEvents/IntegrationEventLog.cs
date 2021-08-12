namespace MASA.BuildingBlocks.ReadWriteSpliting.CQRS.IntegrationEvents
{
    public class IntegrationEventLog
    {
        public Guid Id { get; private set; }

        public string EventTypeName { get; private set; } = null!;

        [NotMapped]
        public string EventTypeShortName => EventTypeName.Split('.')?.Last()!;

        [NotMapped]
        public IntegrationEvent Event { get; private set; } = null!;

        public IntegrationEventStates State { get; set; } = IntegrationEventStates.NotPublished;

        public int TimesSent { get; set; } = 0;

        public DateTime CreationTime { get; private set; } = DateTime.Now;

        public string Content { get; private set; } = null!;

        public Guid TransactionId { get; private set; } = Guid.Empty;

        private IntegrationEventLog() { }

        public IntegrationEventLog(IntegrationEvent @event, Guid transactionId)
        {
            Id = @event.Id;
            CreationTime = @event.CreationTime;
            EventTypeName = @event.GetType().FullName!;
            Content = System.Text.Json.JsonSerializer.Serialize(@event);
            State = IntegrationEventStates.NotPublished;
            TimesSent = 0;
            TransactionId = transactionId;
        }


        public IntegrationEventLog DeserializeJsonContent(Type type)
        {
            Event = (System.Text.Json.JsonSerializer.Deserialize(Content, type) as IntegrationEvent)!;
            return this;
        }
    }
}
