using System.Collections;

namespace Collections;

class Program
{
    static void Main(string[] args)
    {
        // Array();
        // ArrayList();
        // List(); *** (Most Popular) ***
        // ListExample();
        // Dictionary();
    }

    private static void Dictionary()
    {
        Dictionary<string, string> dictionary = new Dictionary<string, string>();
        dictionary.Add("book", "kitap");
        dictionary.Add("table", "tablo");
        dictionary.Add("computer", "bilgisayar");
        
        Console.WriteLine(dictionary["table"]); //tablo

        foreach (var item in dictionary)
        {
            Console.WriteLine(item);
            /*
            [book, kitap]
            [table, tablo]
            [computer, bilgisayar]
            */
        }

        foreach (var item in dictionary)
        {
            Console.WriteLine(item.Value);
            
            /*
            kitap
            tablo
            bilgisayar
            */
        }

        dictionary.ContainsKey("glass"); // have glass?
    }

    private static void List()
    {
        List<string> cities = new List<string>();
        cities.Add("Ankara");
        cities.Add("Istanbul");

        foreach (var city in cities)
        {
            Console.WriteLine(city);
        }
    }

    private static void ArrayList()
    {
        ArrayList citiesList = new ArrayList();
        citiesList.Add("Ankara");
        citiesList.Add("Istanbul");
        citiesList.Add("Adana");

        foreach (var city in citiesList)
        {
            Console.WriteLine(city);
        }

        citiesList.Add("Zonguldak");
        Console.WriteLine(citiesList[3]);
    }

    private static void Array()
    {
        string[] cities = new string[2] { "Ankara", "Istanbul" };
        cities = new string[3];
        Console.WriteLine(cities[0]);
    }
    
    private static void ListExample()
    {
        List<Customer> customers = new List<Customer>();
        customers.Add(new Customer{Id = 1, FirstName = "Yunus"});
        customers.Add(new Customer{Id = 2, FirstName = "Emre"});

        foreach (var customer in customers)
        {
            Console.WriteLine(customer.FirstName);
        }
    }
}

class Customer
{
    public int Id { get; set; }
    public string FirstName { get; set; }
}
