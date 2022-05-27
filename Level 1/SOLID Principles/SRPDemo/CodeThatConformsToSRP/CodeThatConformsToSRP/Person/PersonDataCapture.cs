using System;

namespace CodeThatConformsToSRP.Person
{
    public class PersonDataCapture
    {
        public Person Capture()
        {
            // Ask for user information
            var user = new Person();

            Console.Write("What is your first name: ");
            user.FirstName = Console.ReadLine();

            Console.Write("What is your last name: ");
            user.LastName = Console.ReadLine();

            Console.Write("What is your id number: ");
            user.IdNumber = Console.ReadLine();

            return user;
        }
    }
}
