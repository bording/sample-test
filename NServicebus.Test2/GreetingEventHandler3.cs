﻿using Common;
using NServiceBus;
using System;
using System.Threading.Tasks;
using Upmc.ServiceBus.Messages;

namespace Upmc.Endpoint2
{
    public class GreetingEventHandler3 : IHandleMessages<Greeting3ReceivedEvent>
    {
        public async Task Handle(Greeting3ReceivedEvent message, IMessageHandlerContext context)
        {
            Console.WriteLine($"Received event: {message.GetType().FullName} ({context.MessageId})");           

            await Task.CompletedTask;
        }
    }
}
