namespace Is
{
    interface IInvoiceCreator
    {
        void CreateInvoice();
    }

    interface IInvoiceRepository
    {
        void Save();
    }

    interface IInvoiceEmailSender
    {
        void SendEmail();
    }

    interface IInvoicePdfGenerator
    {
        void GeneratePdf();
    }

    interface IInvoicePrinter
    {
        void Print();
    }

    // One fat interface

    class PdfGenerator : IInvoicePdfGenerator
    {
        public void GeneratePdf()
        {
            //Logic to generate Pdf
        }
    }

    class EmailService : IInvoiceEmailSender
    {
        public void SendEmail() { }
    }
}
