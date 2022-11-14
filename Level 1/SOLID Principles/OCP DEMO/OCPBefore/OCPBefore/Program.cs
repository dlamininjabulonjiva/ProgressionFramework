namespace OCPBefore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            const int salesInvoiceAmount = 5000;
            var salesInvoice = new Invoice();
            var salesInvoiceDiscount = salesInvoice.GetInvoiceDiscount(salesInvoiceAmount, InvoiceType.SalesInvoice);

            const int overdueInvoiceAmount = 15000;
            var overdueInvoice = new Invoice();
            var overdueInvoiceDiscount = overdueInvoice.GetInvoiceDiscount(overdueInvoiceAmount, InvoiceType.OverdueInvoice);

            const int finalInvoiceAmount = 32000;
            var finalInvoice = new Invoice();
            var finalInvoiceDiscount = finalInvoice.GetInvoiceDiscount(finalInvoiceAmount, InvoiceType.FinalInvoice);

            PrintInvoice("Builders Sales Invoice with the discount of 3 percent", salesInvoiceAmount, salesInvoiceDiscount);
            PrintInvoice("Overdue Invoice with the discount of 10 percent", overdueInvoiceAmount, overdueInvoiceDiscount);
            PrintInvoice("Final Invoice for product X with the discount of 5 percent", finalInvoiceAmount, finalInvoiceDiscount);
        }

        private static void PrintInvoice(string description, double invoiceAmount, double invoiceWithDiscount)
        {
            Console.WriteLine("Invoice Description: " + description);
            Console.WriteLine("Invoice Amount: " + invoiceAmount);
            Console.WriteLine("Final Amount: " + invoiceWithDiscount);
            Console.WriteLine("-----------------------------------------------------------------------------------------------------");
        }
    }
}