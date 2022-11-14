using System;

namespace OCPAfter.Invoices
{
    public class SalesInvoice : Invoice
    {
        private readonly double _salesInvoiceAmount;
        public SalesInvoice(double salesInvoiceAmount)
        {
            _salesInvoiceAmount = salesInvoiceAmount;
        }

        public override string GetDescription()
        {
            return "Builders Sales Invoice";
        }

        public override double Amount()
        {
            return _salesInvoiceAmount;
        }
    }
}
