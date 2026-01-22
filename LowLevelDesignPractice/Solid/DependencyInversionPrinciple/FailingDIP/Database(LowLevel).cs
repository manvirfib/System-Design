namespace failingDIP
{
    class MySql
    {
        public void SaveToSql(string data)
        {
            //Stored in sql
            Console.WriteLine(data);
        }
    }
    class CosmosDb
    {
        public void SaveToCosmosDb(string data)
        {
            //Stored in sql
            Console.WriteLine(data);
        }
    }
}