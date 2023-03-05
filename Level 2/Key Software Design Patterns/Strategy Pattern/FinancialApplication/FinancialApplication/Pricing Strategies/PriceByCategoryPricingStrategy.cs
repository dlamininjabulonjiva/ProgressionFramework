using System;

namespace FinancialApplication.Pricing_Strategies
{
    public class PriceByCategoryPricingStrategy : IPricingStrategy
    {
        private readonly decimal _markupPercentage;
        private readonly string _category;

        public PriceByCategoryPricingStrategy(decimal markupPercentage, string category)
        {
            _markupPercentage = markupPercentage;
            _category = category;
        }

        public decimal CalculatePrice(decimal price)
        {
            if (_category == "electronics")
            {
                decimal markupAmount = price * _markupPercentage / 100;
                return price + markupAmount;
            }
            else if (_category == "food")
            {
                decimal markupAmount = price * _markupPercentage / 100 + 1;
                return price + markupAmount;
            }
            else
            {
                return price;
            }
        }
    }
}
