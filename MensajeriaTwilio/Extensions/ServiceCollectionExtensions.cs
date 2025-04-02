using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MensajeriaTwilio.Interfaces;
using MensajeriaTwilio.Models;
using MensajeriaTwilio.Services;

namespace MensajeriaTwilio.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddTwilioMessaging(this IServiceCollection services, IConfiguration configuration)
        {
            var options = new TwilioOptions();
            configuration.GetSection("Twilio").Bind(options);

            services.AddSingleton(options);
            services.AddTransient<IMessagingClient, TwilioMessagingClient>();

            return services;
        }
    }
}

