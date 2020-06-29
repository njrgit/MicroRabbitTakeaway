using MicroRabbitTakeaway.Banking.Domain.Interfaces;
using MicroRabbitTakeaway.Banking.Domain.Models;
using System.Collections.Generic;
using MicroRabbitTakeaway.Banking.Data.Context;

namespace MicroRabbitTakeaway.Banking.Data.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private BankingDbContext _context;

        public AccountRepository(BankingDbContext context)
        {
            _context = context;
        }
  
        public IEnumerable<Account> GetAccounts()
        {
            return _context.Accounts;
        }
    }
}
