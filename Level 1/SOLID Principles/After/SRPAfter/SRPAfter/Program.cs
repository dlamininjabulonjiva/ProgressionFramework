using System.Net.Mail;

namespace SRPAfter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var userService = new UserService(new EmailHandler(new SmtpClient()), new DataProcessor());
            userService.Register("njdlamini@gmail.com", "21101902");
        }
    }
}