namespace DIP
{
    // Abstraction
    interface IDatabase
    {
        void Save(string data);
    }

    class MySqlDatabase : IDatabase
    {
        public void Save(string data)
        {
            Console.WriteLine(data); //Stored in the MySql database
        }
    }
    class Cosmosatabase : IDatabase
    {
        public void Save(string data)
        {
            Console.WriteLine(data); //Stored in the Cosmos database
        }
    }
}
