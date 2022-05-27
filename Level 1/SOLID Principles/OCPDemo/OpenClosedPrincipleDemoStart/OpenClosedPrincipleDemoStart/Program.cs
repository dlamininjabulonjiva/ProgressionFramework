using OCPLibrary;

namespace OpenClosedPrincipleDemoStart
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var applicants = new List<PersonModel>
            {
                new PersonModel { FirstName = "John", LastName = "Miller" },
                new PersonModel { FirstName = "Sue", LastName = "Carey" },
                new PersonModel { FirstName = "Nancy", LastName = "Roman" }
            };

            var employees = new List<EmployeeModel>();
            var accountProcessor = new Accounts();

            foreach (var person in applicants)
            {
                employees.Add(accountProcessor.Create(person));
            }

            foreach (var employee in employees)
            {
                Console.WriteLine($"{ employee.FirstName } { employee.LastName }: { employee.EmailAddress }" +
                                  $" IsManager: { employee.IsManager } IsExecutive: { employee.IsExecutive } Password: {employee.Password}");
            }

            Console.ReadLine();
        }
    }
}