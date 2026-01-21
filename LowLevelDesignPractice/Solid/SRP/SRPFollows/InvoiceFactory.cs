class InvoiceFactory
{
    public Invoice CreateInvoice()
    {
        return new Invoice { Amount = 2000, InvoiceName = "Sample Invoice"};
    }
}