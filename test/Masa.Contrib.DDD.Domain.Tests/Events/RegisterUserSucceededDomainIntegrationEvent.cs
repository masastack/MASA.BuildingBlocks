namespace MASA.Contrib.DDD.Domain.Tests.Events;

public record RegisterUserSucceededDomainIntegrationEvent : IntegrationDomainEvent
{
    public override string Topic { get; set; } = nameof(RegisterUserSucceededDomainIntegrationEvent);

    public string Account { get; init; }
}
