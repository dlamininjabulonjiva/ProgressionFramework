using OCPLibrary.Applicants;
using OCPLibrary.Employees;

namespace OpenClosedPrincipleDemoComplete
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var applicants = new Applicants();
            var allApplicants = applicants.GetApplicants();

            var employees = new Employees();
            var allEmployees = employees.GetEmployees(allApplicants);

            foreach (var employee in allEmployees)
            {
                employees.DisplayEmployeeDetails(employee);
            }

            var standardMessages = new StandardMessages();
            standardMessages.EndApplication();
        }
    }
}