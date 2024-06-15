namespace Interface;

class Program
{
    static void Main(string[] args)
    {
        //InterfacesIntro();
        //InterfacesIntro2();

        ICustomerDal[] customerDals = new ICustomerDal[]
        {
            new OracleCustomerDal(),
            new SqlServerCustomerDal()
        };

        foreach (var customerDal in customerDals)
        {
            customerDal.Add();
            customerDal.Update();
            customerDal.Delete();
        }
    }
    
    private static void InterfacesIntro()
    {
        PersonManager manager = new PersonManager();

        Customer customer = new Customer()
        {
            Id = 1,
            FirstName = "Yunus",
            LastName = "Emre",
            Adress = "Ankara"
        };

        Student student = new Student()
        {
            Id = 1,
            FirstName = "Yagmur",
            LastName = "Sena"
        };
        
        manager.Add(customer);
        manager.Add(student);
    }

    interface IPerson
    {
        int Id {
            get;
            set;
        }
        
        string FirstName {
            get;
            set;
        }
        
        string LastName {
            get;
            set;
        }
    }

    class Customer:IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        public string Adress { get; set; }
    }

    class Student:IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        public string Departmant { get; set; }
    }

    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.Id);
            Console.WriteLine(person.FirstName);
            Console.WriteLine(person.LastName);
        }
    }
}