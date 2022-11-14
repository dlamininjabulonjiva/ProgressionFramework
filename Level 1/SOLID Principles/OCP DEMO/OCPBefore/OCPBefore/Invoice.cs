using System;

namespace OCPBefore
{
    public class Invoice
    {
        public double GetInvoiceDiscount(double invoiceAmount, InvoiceType invoiceType)
        {
            double finalAmount = 0;

            if (invoiceType != InvoiceType.SalesInvoice)
            {
                if (invoiceType == InvoiceType.OverdueInvoice)
                {
                    var discountAmount = invoiceAmount * 10 / 100;
                    finalAmount = invoiceAmount - discountAmount;
                }
                else if (invoiceType == InvoiceType.FinalInvoice)
                {
                    var discountAmount = invoiceAmount * 5 / 100;
                    finalAmount = invoiceAmount - discountAmount;
                }
            }
            else
            {
                var discountAmount = invoiceAmount * 3 / 100;
                finalAmount = invoiceAmount - discountAmount;
            }

            return finalAmount;
        }
    }
}
