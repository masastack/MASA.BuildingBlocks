namespace MASA.BuildingBlocks.Dispatcher.InMemory;

public interface IEvent<TId>
{
    TId Id { get; }

    DateTime CreationTime { get; }
}
