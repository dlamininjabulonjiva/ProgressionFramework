namespace DIPAfter;

public class BonusSalary: ISalary
{
    public double CalculateSalary(double billingRate)
    {
        var grossSalary = billingRate * 8 * 30;
        var bonus = grossSalary * 0.5;
        return bonus;
    }
}