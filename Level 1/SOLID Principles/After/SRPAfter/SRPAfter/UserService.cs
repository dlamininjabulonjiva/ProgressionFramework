using System.ComponentModel.DataAnnotations;
using System.Net.Mail;

namespace SRPAfter
{
    public class UserService
    {
        private readonly EmailHandler _emailHandler;
        private readonly DataProcessor _dataProcessor;

        public UserService(EmailHandler emailHandler, DataProcessor dataProcessor)
        {
            _emailHandler = emailHandler;
            _dataProcessor = dataProcessor;
        }

        public void Register(string email, string password)
        {
            if (!_emailHandler.ValidateEmail(email))
            {
                throw new ValidationException("Please enter a valid email");
            }

            var user = new User()
            {
                Email = email,
                Password = password
            };

            _dataProcessor.AddUser(user);
            _emailHandler.SendWelcomeEmail(new MailMessage("mysite@nowhere.com", email) { Subject = "Thank you for creating an account" });
        }
    }
}
