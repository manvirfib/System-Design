namespace DIP
{
    class InvoiceService
    {
        IDatabase database;
        public InvoiceService(IDatabase database)
        {
            this.database = database;
        }
        public void SaveToDb(string data)
        {
            database.Save(data);
        }
    }
}
/*
Dependency Inversion Principle — One Line
High-level modules should not depend on low-level modules. Both should depend on abstractions.
Here, the abstraction is IDatabase.
Now the client can directly pass the type of database as they want.

NOTE:
It became loosly coupled + Easy to test.
*/