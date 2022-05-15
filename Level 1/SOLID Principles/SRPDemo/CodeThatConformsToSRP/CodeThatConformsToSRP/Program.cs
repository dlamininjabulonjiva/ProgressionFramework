using CodeThatConformsToSRP.Messaging;
using CodeThatConformsToSRP.Person;
using CodeThatConformsToSRP.UseAccount;

namespace CodeThatConformsToSRP
{
    public class Program
    {
        public static void Main(string[] args)
        {
            StandardMessages.WelcomeMessage();

            var user = PersonDataCapture.Capture();

            var isUserValid = PersonValidator.Validate(user);

            if (!isUserValid)
            {
                StandardMessages.EndApplication();
                return;
            }

            AccountGenerator.CreatePersonUsername(user);

            StandardMessages.EndApplication();
        }
    }
}