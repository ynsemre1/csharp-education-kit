namespace Exceptions;

class Program
{
    static void Main(string[] args)
    {
        // ExceptionIntro();
        try
        {
            CustomException();
        }
        catch (RecordNotFoundException e)
        {
            Console.WriteLine(e.Message);
        }

        HandleException(() =>
        {
            CustomException();
        });
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