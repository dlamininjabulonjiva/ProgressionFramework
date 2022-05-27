using CodeViolatingSRP.Accounts;

namespace CodeViolatingSRP
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my application!");

            // Ask for user information
            var user = new Person.Person();
            Console.Write("What is your first name: ");
            user.FirstName = Console.ReadLine();

            Console.Write("What is your last name: ");
            user.LastName = Console.ReadLine();

            Console.Write("What is your id number: ");
            user.IdNumber = Console.ReadLine();

            // Checks to be sure the first and last names are valid
            if (string.IsNullOrWhiteSpace(user.FirstName))
            {
                Console.WriteLine("You did not give us a valid first name!");
                Console.ReadLine();
                return;
            }

            if (string.IsNullOrWhiteSpace(user.LastName))
            {
                Console.WriteLine("You did not give us a valid last name!");
                Console.ReadLine();
                return;
            }

            // Create account
            var random = new Random();

            var account = new Account()
            {
                Username = user.FirstName?.Substring(0, 1) + user.LastName,
                IdNumber = user.IdNumber,
                Password = user.FirstName + user.FirstName?.Length,
                OpeningBalance = random.Next(100, 15000)
            };

            // Display account details
            Console.WriteLine($"Username: { account.Username} Password: { account.Password}" +
                              $" Id Number: { account.IdNumber } Opening Balance: { account.OpeningBalance } ");

            Console.ReadLine();
        }
    }
}