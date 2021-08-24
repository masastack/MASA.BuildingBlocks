namespace MASA.BuildingBlocks.Dispatcher.InMemory;

public interface IEvent
{
    Guid Id { get; }

    DateTime CreationTime { get; }
}
