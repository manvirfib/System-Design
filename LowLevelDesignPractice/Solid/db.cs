class DB
{
    List<Invoice> invoices;
    public DB()
    {
        invoices = new();
    }
    public void Save(Invoice invoice)
    {
        invoices.Add(invoice);
    }
}