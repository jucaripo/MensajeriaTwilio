using System;
using MensajeriaTwilio.Services;

namespace MensajeriaTwilio.Interfaces
{
    public interface IMessagingClient
    {
        Task SendMessageAsync(string to, string message, MessagingType type);
    }
}

