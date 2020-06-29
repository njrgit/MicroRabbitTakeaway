using System;
using System.Collections.Generic;
using System.Text;
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
        }
    }
}
