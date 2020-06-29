using System;
using System.Collections.Generic;
using System.Text;
using MicroRabbitTakeaway.Banking.Application.Interfaces;
using MicroRabbitTakeaway.Banking.Application.Services;
using MicroRabbitTakeaway.Banking.Data.Context;
using MicroRabbitTakeaway.Banking.Data.Repository;
using MicroRabbitTakeaway.Banking.Domain.Interfaces;
using MicroRabbitTakeaway.Domain.Core.Bus;
using MicroRabbitTakeaway.Infra.Bus;
using Microsoft.Extensions.DependencyInjection;

namespace MicroRabbitTakeaway.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Domain Bus
            services.AddTransient<IEventBus, RabbitMQBus>();

            //Application Services
            services.AddTransient<IAccountService, AccountService>();

            //Data
            services.AddTransient<IAccountRepository, AccountRepository>();
            services.AddTransient<BankingDbContext>();

        }
    }
}
