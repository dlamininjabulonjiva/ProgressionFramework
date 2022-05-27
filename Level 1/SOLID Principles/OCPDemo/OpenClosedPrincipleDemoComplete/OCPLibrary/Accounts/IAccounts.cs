using OCPLibrary.Applicants;
using OCPLibrary.Employees;

namespace OCPLibrary.Accounts;

public interface IAccounts
{
    EmployeeModel Create(IApplicantModel person);
}