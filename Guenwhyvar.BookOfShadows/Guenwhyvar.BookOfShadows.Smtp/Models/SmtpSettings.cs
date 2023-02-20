#nullable disable 
using Guenwhyvar.BookOfShadows.Smtp.Interfaces;

namespace Guenwhyvar.BookOfShadows.Smtp.Models
{
    public sealed class SmtpSettings : ISmtpSettings
    {
        public string Host { get; set; }
        public int Port { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool UseSsl { get; set; }
        public string DisplayName { get; set; }
        public string FromAddress { get; set; }
    }
}
