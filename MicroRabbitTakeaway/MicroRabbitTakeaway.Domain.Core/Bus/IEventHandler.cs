using System.Threading.Tasks;
using MicroRabbitTakeaway.Domain.Core.Events;

namespace MicroRabbitTakeaway.Domain.Core.Bus
{
    public interface IEventHandler<in TEvent> : IEventHandler where TEvent : Event
    {
        Task Handle(TEvent @event);
    }

    public interface IEventHandler
    {

    }
}