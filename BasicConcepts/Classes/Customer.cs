namespace Classes;

class Customer
{
    // Property
    public int Id { get; set; }

    private string _firstName;

    public string FirstName
    {
        // Encapsulation
        get { return "Mr." + _firstName; }
        set { _firstName = value; }
    }

    public string LastName { get; set; }
    public string City { get; set; }
}