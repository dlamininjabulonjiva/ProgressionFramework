using CodeThatConformsToSRP.Messaging;
using CodeThatConformsToSRP.Person;
using CodeThatConformsToSRP.UseAccount;

namespace CodeThatConformsToSRP
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var standardMessages = new StandardMessages();
            standardMessages.WelcomeMessage();

            var personDataCapture = new PersonDataCapture();
            var user = personDataCapture.Capture();

            var personValidator = new PersonValidator();
            var isUserValid = personValidator.Validate(user);

            if (!isUserValid)
            {
                standardMessages.EndApplication();
                return;
            }

            var accountGenerator = new AccountGenerator();
            var account = accountGenerator.Create(user);

            var accountDetails = new AccountDetails();
            accountDetails.DisplayAccountDetails(account);

            standardMessages.EndApplication();
        }
    }
}