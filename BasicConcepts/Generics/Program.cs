namespace Generics;

class Program
{
    static void Main(string[] args)
    {
        Utilites utilites = new Utilites();
        List<string> result = utilites.BuildList<string>("Ankara", "İmzmir", "Adana");

        foreach (var item in result)
        {
            Console.WriteLine(item);
        }

        List<Customer> resultCustomer = utilites.BuildList<Customer>(new Customer{FirstName = "Yunus"}, new Customer{FirstName = "Emre"});
        foreach (var customer in resultCustomer)
        {
            Console.WriteLine(customer.FirstName);
        }
    }
}

class Utilites
{
    public List<T> BuildList<T>(params T[] items)
    {
        return new List<T>(items);
    }
}

class Customer
{
    public string FirstName { get; set; }
}

interface ICustomerDal:IRepository<Customer>
{
    
}

class Product
{
    
}

interface IProductDal:IRepository<Product>
{
    
}

// T = Type
interface IRepository<T> where T:class, new()
{
    List<T> GetAll();
    T Get(int id);
    void Add(T entity);
    void Delete(T entity);
    void Update(T entity);
}

class ProductDal:IProductDal
{
    public List<Product> GetAll()
    {
        throw new NotImplementedException();
    }

    public Product Get(int id)
    {
        throw new NotImplementedException();
    }

    public void Add(Product entity)
    {
        throw new NotImplementedException();
    }

    public void Delete(Product entity)
    {
        throw new NotImplementedException();
    }

    public void Update(Product entity)
    {
        throw new NotImplementedException();
    }
}

class CustomerDal:ICustomerDal
{
    public List<Customer> GetAll()
    {
        throw new NotImplementedException();
    }

    public Customer Get(int id)
    {
        throw new NotImplementedException();
    }

    public void Add(Customer entity)
    {
        throw new NotImplementedException();
    }

    public void Delete(Customer entity)
    {
        throw new NotImplementedException();
    }

    public void Update(Customer entity)
    {
        throw new NotImplementedException();
    }
}



