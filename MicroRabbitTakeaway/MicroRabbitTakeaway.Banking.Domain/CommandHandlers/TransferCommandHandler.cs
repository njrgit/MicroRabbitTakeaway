using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using MicroRabbitTakeaway.Banking.Domain.Commands;
using MicroRabbitTakeaway.Banking.Domain.Events;
using MicroRabbitTakeaway.Domain.Core.Bus;

namespace MicroRabbitTakeaway.Banking.Domain.CommandHandlers
{
    public class TransferCommandHandler : IRequestHandler<CreateTransferCommand, bool>
    {
        private readonly IEventBus _eventBus;

        public TransferCommandHandler(IEventBus eventBus)
        {
            _eventBus = eventBus;
        }

        public Task<bool> Handle(CreateTransferCommand request, CancellationToken cancellationToken)
        {
            _eventBus.Publish(new TransferCreatedEvent(request.From,request.To,request.Amount));

            return Task.FromResult(true);
        }
    }
}
