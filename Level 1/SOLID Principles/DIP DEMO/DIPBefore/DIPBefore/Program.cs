namespace DIPBefore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var employee = new Employee
            {
                FirstName = "David",
                LastName = "Walker",
                BillingRate = 130
            };
            Console.WriteLine(employee.FirstName + " " + employee.LastName + "'s' monthly salary is R" + employee.GetSalary());
        }
    }
}
