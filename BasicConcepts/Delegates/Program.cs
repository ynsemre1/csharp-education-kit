namespace Delegates;

public delegate void MyDelegate();

public delegate void ParametersDelegete(string text);

class Program
{
    static void Main(string[] args)
    {
        CustomerManager customerManager = new CustomerManager();

        MyDelegate myDelegate = customerManager.SendMessage;
        myDelegate += customerManager.ShowAlert;
        myDelegate -= customerManager.SendMessage;
        myDelegate();

        ParametersDelegete parametersDelegete = customerManager.SendMessageParameters;
        parametersDelegete += customerManager.ShowAlertParameters;
        parametersDelegete("Hello!");
    }
}

public class CustomerManager
{
    public void SendMessage()
    {
        Console.WriteLine("Hello");
    }

    public void ShowAlert()
    {
        Console.WriteLine("Be Careful!");
    }
    
    public void SendMessageParameters(string message)
    {
        Console.WriteLine(message);
    }

    public void ShowAlertParameters(string message)
    {
        Console.WriteLine(message);
    }
}