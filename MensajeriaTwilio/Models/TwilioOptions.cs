using System;
namespace MensajeriaTwilio.Models
{
	public class TwilioOptions
	{
        public string AccountSid { get; set; } = string.Empty;
        public string AuthToken { get; set; } = string.Empty;
        public string SmsFromNumber { get; set; } = string.Empty;
        public string WhatsAppFromNumber { get; set; } = "whatsapp:+14155238886"; // default sandbox

    }
}

