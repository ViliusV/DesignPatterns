﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    internal class DesktopComputer : Participant
    {
        public DesktopComputer(string key, IMediator mediator) : base(key, mediator)
        {

        }
        public override void SendCommand(string receiver, string command)
        {
            Console.WriteLine($"Sending {command} command to {receiver}.");
            base.SendCommand(receiver, command);
        }
        public override void ReceiveCommand(string sender, string command)
        {
            Console.Write($"Desktop computer {key} received a command. ");
            base.ReceiveCommand(sender, command);
        }
    }
}
