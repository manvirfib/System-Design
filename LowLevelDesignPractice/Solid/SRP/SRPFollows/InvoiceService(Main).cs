class InvoiceService
{
    readonly InvoiceFactory _factory;
    readonly InvoiceRepository _repo;
    readonly EmailService _email;
    public InvoiceService(InvoiceFactory factory, InvoiceRepository repo, EmailService email) // It is always better to have interfaces here, not the classes type directly, because in future if you want to change the functionality you should not change this existing code.
    {
        _factory = factory;
        _repo = repo;
        _email = email;
    }
    public void CreateInvoice()
    {
        var invoice = _factory.CreateInvoice();
        _repo.SaveToDb(invoice);
        _email.Send("abs@gmail.com", "Invoice created", "Invoice attached");
    }
}
// Now every class has one reason to change