using OCPLibrary.Applicants;

namespace OCPLibrary.Employees
{
    public class Employees
    {
        public List<EmployeeModel> GetEmployees(List<IApplicantModel> applicants)
        {
            var employees = new List<EmployeeModel>();

            foreach (var person in applicants)
            {
                employees.Add(person.AccountProcessor.Create(person));
            }

            return employees;
        }

        public void DisplayEmployeDetails(EmployeeModel employee)
        {
            Console.WriteLine($"{employee.FirstName} {employee.LastName}: {employee.EmailAddress}" +
                              $" IsManager: {employee.IsManager} IsExecutive: {employee.IsExecutive} Password: {employee.Password}");
        }
    }
}
