namespace VirtualMethods;

class Program
{
    static void Main(string[] args)
    {
        SqlServer sqlServer = new SqlServer();
        sqlServer.Add();
        
        MySql mySql = new MySql();
        mySql.Add();
    }

    class Database
    {
        public virtual void Add()
        {
            Console.WriteLine("Added by Default");
        }

        public virtual void Delete()
        {
            Console.WriteLine("Deleted by Default");
        }
    }

    class SqlServer : Database
    {
        public override void Add()
        {
            Console.WriteLine("Added by Sql Code");
            //base.Add();
        }
    }

    class MySql : Database
    {
        
    }
}