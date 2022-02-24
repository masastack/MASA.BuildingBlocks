﻿namespace MASA.Contrib.DDD.Domain.Tests;

[TestClass]
public class DomainIntegrationEventBus
{
    private Assembly[] _defaultAssemblies = default!;
    private IServiceCollection _services = default!;
    private Mock<IIntegrationEventBus> _integrationEventBus = default!;
    private Mock<IUnitOfWork> _uoW = default!;
    private IOptions<DispatcherOptions> _dispatcherOptions = default!;

    [TestInitialize]
    public void Initialize()
    {
        _defaultAssemblies = AppDomain.CurrentDomain.GetAssemblies();
        _services = new ServiceCollection();
        _integrationEventBus = new();
        _integrationEventBus.Setup(eventBus => eventBus.PublishAsync(It.IsAny<IIntegrationEvent>())).Verifiable();
        _uoW = new();
        _dispatcherOptions = Options.Create(new DispatcherOptions(new ServiceCollection()));
    }

    [TestMethod]
    public async Task PublishQueueAsync()
    {
        _services.AddEventBus(opt =>
        {
            opt.Assemblies = _defaultAssemblies;
        });
        var serviceProvider = _services.BuildServiceProvider();
        var eventBus = serviceProvider.GetRequiredService<IEventBus>();
        var payment = new
        {
            orderId = Guid.NewGuid(),
            money = 100,
            payTime = DateTime.UtcNow
        };
        var domainEventBus = new DomainEventBus(eventBus, _integrationEventBus.Object, _uoW.Object, _dispatcherOptions);

        var domainEvent = new PaymentSucceededDomainEvent(payment.orderId.ToString());
        await domainEventBus.Enqueue(domainEvent);

        var integraionDomainEvent = new PaymentSucceededIntegraionDomainEvent(payment.orderId.ToString(), payment.money, payment.payTime);
        await domainEventBus.Enqueue(integraionDomainEvent);
        await domainEventBus.PublishQueueAsync();
        Assert.IsTrue(domainEvent.Result);
        _integrationEventBus.Verify(eventBus => eventBus.PublishAsync(It.IsAny<IIntegrationEvent>()), Times.Once);
    }
}
