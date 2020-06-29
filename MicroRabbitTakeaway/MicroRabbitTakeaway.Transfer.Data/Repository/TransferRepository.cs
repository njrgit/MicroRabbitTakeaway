using System.Collections.Generic;
using MicroRabbitTakeaway.Transfer.Data.Context;
using MicroRabbitTakeaway.Transfer.Domain.Interfaces;
using MicroRabbitTakeaway.Transfer.Domain.Models;

namespace MicroRabbitTakeaway.Transfer.Data.Repository
{
    public class TransferRepository : ITransferRepository
    {
        private TransferDbContext _context;

        public TransferRepository(TransferDbContext context)
        {
            _context = context;
        }
  
        public IEnumerable<TransferLog> GetTransferLogs()
        {
            return _context.TransferLogs;
        }
    }
}
