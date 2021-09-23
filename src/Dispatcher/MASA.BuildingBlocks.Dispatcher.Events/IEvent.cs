namespace MASA.BuildingBlocks.Dispatcher.Events;
public interface IEvent
{
    Guid Id { get; }

    DateTime CreationTime { get; }
}

public interface IEvent<TResult> : IEvent
    where TResult : notnull
{
    TResult Result { get; set; }
}
