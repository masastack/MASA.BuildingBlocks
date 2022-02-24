namespace Masa.BuildingBlocks.Ddd.Domain.Services;
public interface IDomainService
{
    IDomainEventBus EventBus { get; }
}
