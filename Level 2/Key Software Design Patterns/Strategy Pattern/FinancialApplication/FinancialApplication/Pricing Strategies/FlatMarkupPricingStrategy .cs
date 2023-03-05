using System;

namespace FinancialApplication.Pricing_Strategies
{
    public class FlatMarkupPricingStrategy : IPricingStrategy
    {
        private readonly decimal _markupPercentage;

        public FlatMarkupPricingStrategy(decimal markupPercentage)
        {
            _markupPercentage = markupPercentage;
        }

        public decimal CalculatePrice(decimal price)
        {
            decimal markupAmount = price * _markupPercentage / 100;
            return price + markupAmount;
        }
    }
}
