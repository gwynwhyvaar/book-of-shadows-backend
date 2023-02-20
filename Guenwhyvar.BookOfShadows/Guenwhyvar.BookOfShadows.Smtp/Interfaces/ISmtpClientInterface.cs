using Guenwhyvar.BookOfShadows.Smtp.Models;

namespace Guenwhyvar.BookOfShadows.Smtp.Interfaces
{
    public interface ISmtpClientInterface
    {
        Task SendEmailAsync(SmtpMessage smtpMessage);
    }
}
