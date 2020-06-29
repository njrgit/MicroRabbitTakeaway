using System;
using System.Collections.Generic;
using System.Text;
using MicroRabbitTakeaway.Banking.Domain.Models;

namespace MicroRabbitTakeaway.Banking.Domain.Interfaces
{
    public interface IAccountRepository
    {
        IEnumerable<Account> GetAccounts();

    }
}
