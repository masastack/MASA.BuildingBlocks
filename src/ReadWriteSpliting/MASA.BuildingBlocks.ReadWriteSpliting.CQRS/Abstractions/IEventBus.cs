using MASA.BuildingBlocks.ReadWriteSpliting.CQRS.Events;
using System.Threading.Tasks;

namespace MASA.BuildingBlocks.ReadWriteSpliting.CQRS.Abstractions
{
    public interface IEventBus
    {
        Task PublishAsync<TEvent>(TEvent @event)
            where TEvent : EventBase;
    }
}
