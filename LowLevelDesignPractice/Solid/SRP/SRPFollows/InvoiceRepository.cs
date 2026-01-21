class InvoiceRepository
{
    public void SaveToDb(Invoice invoice)
    {
        DB dB = new DB();
        dB.Save(invoice);
    }
}