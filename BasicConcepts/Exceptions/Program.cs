namespace Exceptions;

class Program
{
    static void Main(string[] args)
    {
        // ExceptionIntro();
        // TryCatch();
        // ActionDemo();

        Func<int, int, int> add = Add;
        Console.WriteLine(add(3,4));

        Func<int> getRandomNumber = delegate()
        {
            Random random = new Random();
            return random.Next(1, 100);
        };
        Console.WriteLine(getRandomNumber());

        Func<int> getRandomNumberSecond = () => new Random().Next(1,100);
        Console.WriteLine(getRandomNumberSecond());
    }

    static int Add(int x, int y)
    {
        return x + y;
    }
    
    private static void ActionDemo()
    {
        HandleException(() =>
        {
            CustomException();
        });
    }

    private static void TryCatch()
    {
        try
        {
            CustomException();
        }
        catch (RecordNotFoundException e)
        {
            Console.WriteLine(e.Message);
        }
    }

    private static void HandleException(Action action)
    {
        try
        {
            action.Invoke();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
    }

    private static void CustomException()
    {
        List<string> students = new List<string> { "Yunus", "Yağmur", "Arzu" };

        if (!students.Contains("Ahmet"))
        {
            throw new RecordNotFoundException("Record not found!");
        }
        else
        {
            Console.WriteLine("Record Found!");
        }
    }

    private static void ExceptionIntro()
    {
        try
        {
            string[] students = new string[3] { "Yunus", "Yagmur", "Arzu" };
            students[3] = "Nisa";
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception.Message);
        }
    }
}