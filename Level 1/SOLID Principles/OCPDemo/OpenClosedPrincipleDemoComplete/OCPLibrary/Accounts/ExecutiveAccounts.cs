using OCPLibrary.Applicants;
using OCPLibrary.Employees;

namespace OCPLibrary.Accounts
{
    public class ExecutiveAccounts : IAccounts
    {
        public EmployeeModel Create(IApplicantModel person)
        {
            var employee = new EmployeeModel
            {
                FirstName = person.FirstName,
                LastName = person.LastName,
                EmailAddress = $"{ person.FirstName }.{person.LastName}@chillisoft.co.za",
                Password = person.FirstName + person.FirstName?.Length,
                IsManager = true,
                IsExecutive = true
            };

            return employee;
        }
    }
}
