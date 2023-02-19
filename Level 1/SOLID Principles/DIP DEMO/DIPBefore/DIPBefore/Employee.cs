using System;

namespace DIPBefore
{
    public class Employee
    {
        public string FirstName;
        public string LastName;
        public double BillingRate;

        //Here DIP is violated, because this class uses the concrete Salary class and therefore it is tightly coupled, any change in the Salary class will break the code.
        public double GetSalary()
        {
            var salary = new GrossSalary();
            return salary.CalculateSalary(BillingRate);
        }
    }
}
