using System;

namespace FinancialApplication
{
    public class FinancialInstrument
    {
        private readonly decimal _price;
        private IPricingStrategy _pricingStrategy;

        public FinancialInstrument(decimal price, IPricingStrategy pricingStrategy)
        {
            _price = price;
            _pricingStrategy = pricingStrategy;
        }

        public decimal CalculatePrice()
        {
            return _pricingStrategy.CalculatePrice(_price);
        }

        public void SetPricingStrategy(IPricingStrategy pricingStrategy)
        {
            _pricingStrategy = pricingStrategy;
        }
    }
}
