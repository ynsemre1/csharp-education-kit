using System.Reflection;

namespace Reflection;

class Program
{
    static void Main(string[] args)
    {
        var type = typeof(Math);
        Math math = (Math)Activator.CreateInstance(type,6,7);
        
        // Console.WriteLine(math.Additional(4,5));
        // Console.WriteLine(math.NewAdditional());
        
        var instance = Activator.CreateInstance(type,6,7);
        
        MethodInfo methodInfo = instance.GetType().GetMethod("NewAdditional");
        Console.WriteLine(methodInfo.Invoke(instance,null));

        var methods = type.GetMethods();

        foreach (var info in methods)
        {
            Console.WriteLine("Methods Name: {0}", info.Name);
            foreach (var parameterInfo in info.GetParameters())
            {
                Console.WriteLine("Parameter Info: {0}", parameterInfo.Name);
            }

            foreach (var attributes in info.GetCustomAttributes())
            {
                Console.WriteLine("Attributes Name: {0}", attributes.GetType().Name);
            }
        }
    }

    class Math
    {
        private int _num1;
        private int _num2;

        public Math(int num1, int num2)
        {
            _num1 = num1;
            _num2 = num2;
        }
        
        public int Additional(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Multiplication(int num1, int num2)
        {
            return num1 * num2;
        }
        
        public int NewAdditional()
        {
            return _num1 + _num2;
        }
        
        [MethodName("Carpma")]
        public int NewMultiplication()
        {
            return _num1 * _num2;
        }
    }

    class MethodNameAttribute:Attribute
    {
        public MethodNameAttribute(string name)
        {
            
        }
    }
}