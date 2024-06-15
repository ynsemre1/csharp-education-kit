namespace InterfaceDemo;

class Program
{
    static void Main(string[] args)
    {
        IWorker[] workers = new IWorker[3]
        {
            new Manager(),
            new Worker(),
            new Robot()
        };

        foreach (var worker in workers)
        {
            worker.Work();
        }

        IEat[] eats = new IEat[]
        {
            new Manager(),
            new Worker()
        };

        foreach (var eat in eats)
        {
            eat.Eat();
        }
    }
    
    //SOLID, Interface Segregation
    interface IWorker
    {
        void Work();
    }

    interface IEat
    {
        void Eat();
    }

    interface ISalary
    {
        void GetSalary();
    }

    class Manager : IWorker,IEat,ISalary
    {
        public void Work()
        {
        }

        public void Eat()
        {
        }

        public void GetSalary()
        {
        }
    }

    class Worker : IWorker,IEat,ISalary
    {
        public void Work()
        {
            
        }

        public void Eat()
        {
        }

        public void GetSalary()
        {
        }
    }

    class Robot : IWorker
    {
        public void Work()
        {
        }
    }
}