using System;

namespace OCPAfter
{
    public class WithDiscount: InvoiceDecorator
    {
        private readonly Invoice _invoice;
        private readonly double _discountPercent;

        public WithDiscount(Invoice invoice, double discountPercent = 0)
        {
            _invoice = invoice;
            _discountPercent = discountPercent;
        }

        public override string GetDescription()
        {
            return _invoice.GetDescription() + " with the discount of " + _discountPercent + " percent";
        }

        public override double Amount()
        {
            var discountAmount = _invoice.Amount() * _discountPercent / 100;
            return _invoice.Amount() - discountAmount;
        }
    }
}
