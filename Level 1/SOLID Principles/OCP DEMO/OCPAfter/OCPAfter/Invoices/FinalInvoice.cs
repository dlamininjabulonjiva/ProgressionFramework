using System;

namespace OCPAfter.Invoices
{
    public class FinalInvoice : Invoice
    {
        private readonly double _finalInvoiceAmount;
        public FinalInvoice(double finalInvoiceAmount)
        {
            _finalInvoiceAmount = finalInvoiceAmount;
        }

        public override string GetDescription()
        {
            return "Final Invoice for product X";
        }

        public override double Amount()
        {
            return _finalInvoiceAmount;
        }
    }
}
