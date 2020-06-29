﻿using System;
using System.Collections.Generic;
using System.Text;
using MediatR;

namespace MicroRabbitTakeaway.Banking.Domain.Commands
{
    public class CreateTransferCommand : TransferCommand, IRequest<Unit>
    {
        public CreateTransferCommand(int from, int to, decimal amount)
        {
            From = from;
            To = to;
            Amount = amount;
        }
    }
}
