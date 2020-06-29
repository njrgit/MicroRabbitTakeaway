using System;
using System.Collections.Generic;
using System.Text;
using MicroRabbitTakeaway.Banking.Application.Models;
using MicroRabbitTakeaway.Banking.Domain.Models;

namespace MicroRabbitTakeaway.Banking.Application.Interfaces
{
    public interface IAccountService
    {
        IEnumerable<Account> GetAccounts();

        void Transfer(AccountTransfer accountTransfer);
    }
}
