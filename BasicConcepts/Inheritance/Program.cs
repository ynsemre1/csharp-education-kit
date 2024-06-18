namespace Inheritance;

class Program
{
    static void Main(string[] args)
    {
        Person[] persons = new Person[3]
        {
            new Customer
            {
                Id = 1,
                FirstName = "Yunus",
                LastName = "Emre",
                City = "Ankara"
            }, new Student
            {
                Id = 2,
                FirstName = "Yagmur",
                LastName = "Sena",
                Department = "Software"
            }, new Person
            {
                Id = 3,
                FirstName = "Nisa",
                LastName = "Nur"
            }
        };

        foreach (var person in persons)
        {
            Console.WriteLine(person.Id);
            Console.WriteLine(person.FirstName);
            Console.WriteLine(person.LastName);
        }
    }
}

class Person
{
    public int Id 
    {
        get; set;
    }

    public string FirstName
    {
        get; set;
    }

    public string LastName
    {
        get; set;
    }
}

class Customer : Person
{
    public string City { get; set; }
}

class Student : Person
{
    public string Department { get; set; }
}