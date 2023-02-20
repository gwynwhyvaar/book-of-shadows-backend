#nullable disable 
namespace Guenwhyvar.BookOfShadows.Smtp.Models
{
    public sealed class SmtpMessage
    {
        public SmtpMailAddress To { get; set; }
        public string Subject { get; set; }
        public string MessageId { get; set; }
        public string MessageText { get; set; }
    }
    public class SmtpMailAddress
    {
        public string EmailAddress { get; set; }
        public string DisplayName { get; set; }
    }
}
