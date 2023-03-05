using System;

namespace FinancialApplication
{
    public interface IPricingStrategy
    {
        decimal CalculatePrice(decimal price);
    }
}
