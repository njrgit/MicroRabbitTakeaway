using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using MicroRabbitTakeaway.Domain.Core.Bus;
using MicroRabbitTakeaway.Domain.Core.Commands;
using MicroRabbitTakeaway.Domain.Core.Events;

namespace MicroRabbitTakeaway.Infra.Bus
{
    public sealed class RabbitMQBus : IEventBus
    {
        private readonly IMediator _mediator;

        public Task SendCommand<T>(T command) where T : Command
        {
            return _mediator.Send(command);
        }

        public void Publish<T>(T @event) where T : Event
        {
            throw new NotImplementedException();
        }

        public void Subscribe<T, TH>() where T : Event where TH : IEventHandler<T>
        {
            throw new NotImplementedException();
        }
    }
}
