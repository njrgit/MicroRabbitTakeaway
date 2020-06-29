using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;
using System.Threading.Tasks;
using MicroRabbitTakeaway.Domain.Core.Bus;
using MicroRabbitTakeaway.Transfer.Domain.Events;
using MicroRabbitTakeaway.Transfer.Domain.Interfaces;
using MicroRabbitTakeaway.Transfer.Domain.Models;

namespace MicroRabbitTakeaway.Transfer.Domain.EventHandlers
{
    public class TransferEventHandler : IEventHandler<TransferCreatedEvent>
    {
        private readonly ITransferRepository _transferRepository;

        public TransferEventHandler(ITransferRepository transferRepository)
        {
            _transferRepository = transferRepository;
        }

        public Task Handle(TransferCreatedEvent @event)
        {
            _transferRepository.Add(new TransferLog
            {
                FromAccount = @event.From,
                ToAccount = @event.To,
                TransferAmount = @event.Amount
            });

            return Task.CompletedTask;
        }
    }
}
