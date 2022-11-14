using System;

namespace OCPAfter.Invoices
{
    public class OverdueInvoice : Invoice
    {
        private readonly double _overdueInvoiceAmount;
        public OverdueInvoice(double overdueInvoiceAmount)
        {
            _overdueInvoiceAmount = overdueInvoiceAmount;
        }

        public override string GetDescription()
        {
            return "Overdue Invoice";
        }

        public override double Amount()
        {
            return _overdueInvoiceAmount;
        }
    }
}
