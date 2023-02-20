using Guenwhyvar.BookOfShadows.Smtp.Interfaces;
using Guenwhyvar.BookOfShadows.Smtp.Models;

using MailKit.Net.Smtp;

using MimeKit;

namespace Guenwhyvar.BookOfShadows.Smtp
{
    public sealed class SmtpHandlerClient : ISmtpClientInterface
    {
        private readonly ISmtpSettings _setting;
        public SmtpHandlerClient(ISmtpSettings setting)
        {
            _setting = setting;
        }
        public async Task SendEmailAsync(SmtpMessage smtpMessage)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress(_setting.DisplayName, _setting.FromAddress));
            message.To.Add(new MailboxAddress(smtpMessage.To.DisplayName, smtpMessage.To.EmailAddress));
            message.Subject = smtpMessage.Subject;
            var builder = new BodyBuilder();
            builder.HtmlBody = smtpMessage.MessageText;
            message.Body = builder.ToMessageBody();
            message.MessageId = smtpMessage.MessageId;
            using (var client = new SmtpClient())
            {
                await client.ConnectAsync(_setting.Host, _setting.Port);
                await client.AuthenticateAsync(_setting.Username, _setting.Password);
                await client.SendAsync(message);
                await client.DisconnectAsync(true);
            }
        }
    }
}
