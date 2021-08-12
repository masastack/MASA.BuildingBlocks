using MASA.BuildingBlocks.ReadWriteSpliting.CQRS.Events;
using System.Threading.Tasks;

namespace MASA.BuildingBlocks.ReadWriteSpliting.CQRS.Abstractions
{
    public interface IEventHandler<TEvent>
        where TEvent : Event
    {
        Task HandleAsync(TEvent @event);
    }
}
