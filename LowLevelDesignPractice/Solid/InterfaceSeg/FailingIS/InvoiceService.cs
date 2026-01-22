namespace failingIs
{
    interface IInvoiceService
    {
        void SendEmail();
        void GeneratePDF();
        void CreateInvoice();
        void SaveToDatabase();
    }
    // One fat interface

    class PdfGenerator : IInvoiceService
    {
        public void CreateInvoice()
        {
            throw new NotImplementedException();
        }

        public void GeneratePDF()
        {
            // real logice and only this method is being used, not the complete interface
        }

        public void SaveToDatabase()
        {
            throw new NotImplementedException();
        }

        public void SendEmail()
        {
            throw new NotImplementedException();
        }
    }
}
