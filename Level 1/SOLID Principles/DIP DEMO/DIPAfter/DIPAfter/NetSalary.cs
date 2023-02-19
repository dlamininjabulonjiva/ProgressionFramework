namespace DIPAfter;

public class NetSalary: ISalary
{
    public double CalculateSalary(double billingRate)
    {
        var grossSalary = billingRate * 8 * 30;
        var netSalary = grossSalary - (grossSalary * 0.1);
        return netSalary;
    }
}