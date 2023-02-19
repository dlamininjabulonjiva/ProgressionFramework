using System;

namespace DIPAfter
{
    public class GrossSalary: ISalary
    {
        public double CalculateSalary(double billingRate)
        {
            return billingRate * 8 * 30;
        }
    }
}
