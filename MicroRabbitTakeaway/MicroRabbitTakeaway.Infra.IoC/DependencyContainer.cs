using MediatR;
using MicroRabbitTakeaway.Banking.Application.Interfaces;
using MicroRabbitTakeaway.Banking.Application.Services;
using MicroRabbitTakeaway.Banking.Data.Context;
using MicroRabbitTakeaway.Banking.Data.Repository;
using MicroRabbitTakeaway.Banking.Domain.CommandHandlers;
using MicroRabbitTakeaway.Banking.Domain.Commands;
using MicroRabbitTakeaway.Banking.Domain.Interfaces;
using MicroRabbitTakeaway.Domain.Core.Bus;
using MicroRabbitTakeaway.Infra.Bus;
using MicroRabbitTakeaway.Transfer.Application.Interfaces;
using MicroRabbitTakeaway.Transfer.Application.Services;
using MicroRabbitTakeaway.Transfer.Data.Context;
using MicroRabbitTakeaway.Transfer.Data.Repository;
using MicroRabbitTakeaway.Transfer.Domain.EventHandlers;
using MicroRabbitTakeaway.Transfer.Domain.Events;
using MicroRabbitTakeaway.Transfer.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace MicroRabbitTakeaway.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Domain Bus
            services.AddTransient<IEventBus, RabbitMQBus>();

            //Domain Events
            services.AddTransient<IEventHandler<TransferCreatedEvent>, TransferEventHandler>();


            //Banking Commands
            services.AddTransient<IRequestHandler<CreateTransferCommand, bool>, TransferCommandHandler>();

            //Application Services
            services.AddTransient<IAccountService, AccountService>();
            services.AddTransient<ITransferService, TransferService>();

            //Data
            services.AddTransient<IAccountRepository, AccountRepository>();
            services.AddTransient<ITransferRepository, TransferRepository>();
            services.AddTransient<BankingDbContext>();
            services.AddTransient<TransferDbContext>();

        }
    }
}
