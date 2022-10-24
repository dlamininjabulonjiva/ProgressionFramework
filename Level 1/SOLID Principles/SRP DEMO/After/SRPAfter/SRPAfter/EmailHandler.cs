using System.Net.Mail;

namespace SRPAfter
{
    public class EmailHandler
    {
        private readonly SmtpClient _smtpClient;

        public EmailHandler(SmtpClient smtpClient)
        {
            _smtpClient = smtpClient;
        }

        public bool ValidateEmail(string email)
        {
            return email.Contains("@");
        }

        public void SendWelcomeEmail(MailMessage message)
        {
            _smtpClient.Send(message);
        }
    }
}
