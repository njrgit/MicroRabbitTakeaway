using System;
using System.Collections.Generic;
using System.Text;
using MicroRabbitTakeaway.Domain.Core.Events;

namespace MicroRabbitTakeaway.Domain.Core.Commands
{
    public abstract class Command : Message
    {
        protected Command()
        {
            TimeStamp = DateTime.Now;
        }

        public DateTime TimeStamp { get; protected set; }
    }
}
