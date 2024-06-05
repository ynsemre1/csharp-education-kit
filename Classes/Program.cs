namespace Classes;

class Program
{
    static void Main(string[] args)
    {
        CustomerManager customManager = new CustomerManager();
        customManager.Add();
        customManager.Update();

        ProductManager productManager = new ProductManager();
        productManager.Add();
        productManager.Update();
        
        // First Style
        Customer customer = new Customer();
        customer.City = "Ankara";
        customer.Id = 1;
        customer.FirstName = "Yunus";
        customer.LastName = "Emre";
        
        // Second Style
        Customer secondCustomer = new Customer
        {
            Id = 2, City = "İstanbul", FirstName = "Yagmur", LastName = "Sena"
        };
        
        Console.WriteLine(secondCustomer.FirstName);

    }
}

class CustomerManager
{
    public void Add()
    {
        Console.WriteLine("Customer Added!");
    }

    public void Update()
    {
        Console.WriteLine("Customer Updated!");
    }
}