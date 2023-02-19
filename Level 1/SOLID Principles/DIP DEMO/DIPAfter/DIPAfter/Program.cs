namespace DIPAfter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            PrintGrossSalary();
            PrintNettSalary();
            PrintBonusSalary();
        }

        public static void PrintGrossSalary()
        {
            var grossSalary = SalaryFactory.Create(SalaryType.Gross);
            var employee = new Employee("David", "Walker", 130, grossSalary);
            Console.WriteLine(employee.GetFirstName() + " " + employee.GetLastName() + "'s' gross salary is R" + employee.GetSalary());
        }

        public static void PrintNettSalary()
        {
            var nettSalary = SalaryFactory.Create(SalaryType.Nett);
            var employee = new Employee("David", "Walker", 130, nettSalary);
            Console.WriteLine(employee.GetFirstName() + " " + employee.GetLastName() + "'s' nett salary is R" + employee.GetSalary());
        }

        public static void PrintBonusSalary()
        {
            var bonusSalary = SalaryFactory.Create(SalaryType.Bonuses);
            var employee = new Employee("David", "Walker", 130, bonusSalary);
            Console.WriteLine(employee.GetFirstName() + " " + employee.GetLastName() + "'s' bonus salary is R" + employee.GetSalary());
        }
    }
}