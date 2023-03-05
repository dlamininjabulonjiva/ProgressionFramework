using System;

namespace FinancialApplication.Pricing_Strategies
{
    public class PerPersonMarkupPricingStrategy : IPricingStrategy
    {
        private readonly decimal _markupPercentage;
        private readonly int _numberOfPeople;

        public PerPersonMarkupPricingStrategy(decimal markupPercentage, int numberOfPeople)
        {
            _markupPercentage = markupPercentage;
            _numberOfPeople = numberOfPeople;
        }

        public decimal CalculatePrice(decimal price)
        {
            decimal markupAmount = _numberOfPeople * price * _markupPercentage / 100;
            return price + markupAmount;
        }
    }
}
