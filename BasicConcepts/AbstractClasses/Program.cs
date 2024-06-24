namespace AbstractClasses;

class Program
{
    static void Main(string[] args)
    {
        Database dataBaseSql = new SqlServer();
        Database dataBaseOracle = new Oracle();
        
        dataBaseSql.Deleted();
        dataBaseOracle.Deleted();
    }
    
    abstract class Database
    {
        public void Add()
        {
            Console.WriteLine("Default Added");
        }

        public abstract void Deleted();
    }

    class SqlServer : Database
    {
        public override void Deleted()
        {
            Console.WriteLine("Sql Added");
        }
    }

    class Oracle : Database
    {
        public override void Deleted()
        {
            Console.WriteLine("Oracle Added");
        }
    }
}