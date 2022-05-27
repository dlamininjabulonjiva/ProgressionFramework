using System;
using System.Text;

namespace OCPLibrary
{
    public class Accounts
    {
        public EmployeeModel Create(PersonModel person)
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
