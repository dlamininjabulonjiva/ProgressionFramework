using System.ComponentModel.DataAnnotations;
using System.Net.Mail;

namespace SRPBefore
{
    public class UserService
    {
        public void Register(string email, string password)
        {
            if (!ValidateEmail(email))
            {
                throw new ValidationException("Please enter a valid email");
            }

            var user = new User()
            {
                Email = email,
                Password = password
            };

            ProcessUser(user);
            SendEmail(new MailMessage("mysite@nowhere.com", email) { Subject = "Thank you for creating an account" });
        }

        private static bool ValidateEmail(string email)
        {
            return email.Contains("@");
        }

        private static void SendEmail(MailMessage message)
        {
            var smtpClient = new SmtpClient();
            smtpClient.Send(message);
        }

        private static void ProcessUser(User user)
        {
            Console.Write("User with email: " + user.Email + " has been processed");
        }
    }
}
