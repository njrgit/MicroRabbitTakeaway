using System;
using System.Collections.Generic;
using System.Text;
using MicroRabbitTakeaway.Banking.Application.Interfaces;
using MicroRabbitTakeaway.Banking.Application.Models;
using MicroRabbitTakeaway.Banking.Domain.Commands;
using MicroRabbitTakeaway.Banking.Domain.Interfaces;
using MicroRabbitTakeaway.Banking.Domain.Models;
using MicroRabbitTakeaway.Domain.Core.Bus;

namespace MicroRabbitTakeaway.Banking.Application.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;
        private readonly IEventBus _eventBus;

        public AccountService(IAccountRepository accountRepository, IEventBus eventBus)
        {
            _accountRepository = accountRepository;
            _eventBus = eventBus;
        }

        public IEnumerable<Account> GetAccounts()
        {
            return _accountRepository.GetAccounts();
        }

        public void Transfer(AccountTransfer accountTransfer)
        {
            var createTransferCommand = new CreateTransferCommand(accountTransfer.FromAccount, accountTransfer.ToAccount,accountTransfer.TransferValue);

            _eventBus.SendCommand(createTransferCommand);
        }
    }
}
