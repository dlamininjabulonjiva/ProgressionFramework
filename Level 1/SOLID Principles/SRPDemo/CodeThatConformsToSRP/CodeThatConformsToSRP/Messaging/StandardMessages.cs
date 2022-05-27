using System;

namespace CodeThatConformsToSRP.Messaging
{
    public class StandardMessages
    {
        public void WelcomeMessage()
        {
            Console.WriteLine("Welcome to my application!");
        }

        public void EndApplication()
        {
            Console.Write("Press enter to close...");
            Console.ReadLine();
        }

        public void DisplayValidationError(string fieldName)
        {
            Console.WriteLine($"You did not give us a valid { fieldName }!");
        }
    }
}
