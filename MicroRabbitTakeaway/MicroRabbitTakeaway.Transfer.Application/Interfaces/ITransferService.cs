using System.Collections.Generic;
using MicroRabbitTakeaway.Transfer.Domain.Models;

namespace MicroRabbitTakeaway.Transfer.Application.Interfaces
{
    public interface ITransferService
    {
        IEnumerable<TransferLog> GetTransferLogs();

    }
}
