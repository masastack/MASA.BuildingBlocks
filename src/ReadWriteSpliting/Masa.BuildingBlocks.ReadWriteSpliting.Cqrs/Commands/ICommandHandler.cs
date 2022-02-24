namespace Masa.BuildingBlocks.ReadWriteSpliting.Cqrs.Commands;
public interface ICommandHandler<TCommand> : IEventHandler<TCommand>
    where TCommand : ICommand
{
}
