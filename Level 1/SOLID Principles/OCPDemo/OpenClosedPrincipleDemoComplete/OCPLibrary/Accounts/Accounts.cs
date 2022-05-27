using OCPLibrary.Applicants;
using OCPLibrary.Employees;

namespace OCPLibrary.Accounts
{
    public class Accounts : IAccounts
    {
        public EmployeeModel Create(IApplicantModel person)
        {
            var employee = new EmployeeModel
            {
                FirstName = person.FirstName,
                LastName = person.LastName,
                EmailAddress = $"{ person.FirstName?.Substring(0, 1) }{person.LastName}@chillisoft.co.za",
                Password = person.FirstName + person.FirstName?.Length
            };

            return employee;
        }
    }
}
