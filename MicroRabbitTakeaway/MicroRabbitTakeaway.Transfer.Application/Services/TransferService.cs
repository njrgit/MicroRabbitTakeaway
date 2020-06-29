using System.Collections.Generic;
using MicroRabbitTakeaway.Domain.Core.Bus;
using MicroRabbitTakeaway.Transfer.Application.Interfaces;
using MicroRabbitTakeaway.Transfer.Domain.Interfaces;
using MicroRabbitTakeaway.Transfer.Domain.Models;

namespace MicroRabbitTakeaway.Transfer.Application.Services
{
    public class TransferService : ITransferService
    {
        private readonly ITransferRepository _transferRepository;
        private readonly IEventBus _eventBus;

        public TransferService(ITransferRepository transferRepository, IEventBus eventBus)
        {
            _transferRepository = transferRepository;
            _eventBus = eventBus;
        }

        public IEnumerable<TransferLog> GetTransferLogs()
        {
            return _transferRepository.GetTransferLogs();
        }
    }
}
