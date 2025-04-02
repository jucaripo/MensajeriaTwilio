using System;
using MensajeriaTwilio.Interfaces;
using MensajeriaTwilio.Models;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace MensajeriaTwilio.Services
{
    public class TwilioMessagingClient : IMessagingClient
    {
        private readonly TwilioOptions _options;

        public TwilioMessagingClient(TwilioOptions options)
        {
            _options = options;
            TwilioClient.Init(_options.AccountSid, _options.AuthToken);
        }

        public async Task SendMessageAsync(string to, string message, MessagingType type)
        {
            string from = type == MessagingType.WhatsApp
                ? _options.WhatsAppFromNumber
                : _options.SmsFromNumber;

            var toNumber = type == MessagingType.WhatsApp
                ? new PhoneNumber($"whatsapp:{to}")
                : new PhoneNumber(to);

            var fromNumber = new PhoneNumber(from);

            await MessageResource.CreateAsync(
                to: toNumber,
                from: fromNumber,
                body: message
            );
        }

  
    }
}

