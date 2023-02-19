using System;

namespace DIPAfter
{
    public class Employee: IEmployee
    {
        private readonly string _firstName;
        private readonly string _lastName;
        private readonly double _billingRate;
        private readonly ISalary _salary;

        public Employee(string firstName, string lastName, double billingRate, ISalary salary)
        {
            _firstName = firstName;
            _lastName = lastName;
            _billingRate = billingRate;
            _salary = salary;
        }

        public string GetFirstName()
        {
            return _firstName;
        }

        public string GetLastName()
        {
            return _lastName;
        }

        public double GetSalary()
        {
            return _salary.CalculateSalary(_billingRate);
        }
    }
}
