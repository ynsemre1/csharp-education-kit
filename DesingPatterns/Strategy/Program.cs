using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();

            customerManager.CreditCalculaterBase = new After2010CreditCalculator();
            customerManager.SaveCredit();

            customerManager.CreditCalculaterBase = new Before2010CreditCalculator();
            customerManager.SaveCredit();

            Console.ReadLine();
        }
    }

    abstract class CreditCalculaterBase
    {
        public abstract void Calculate();

    }

    class Before2010CreditCalculator : CreditCalculaterBase
    {
        public override void Calculate()
        {
            Console.WriteLine("Credit Calculated using Before 2010");
        }
    }

    class After2010CreditCalculator : CreditCalculaterBase
    {
        public override void Calculate()
        {
            Console.WriteLine("Credit Calculated using After 2010");
        }
    }

    class CustomerManager
    {
        public CreditCalculaterBase CreditCalculaterBase { get; set; }
        public void SaveCredit()
        {
            Console.WriteLine("Customer Manager Business");
            CreditCalculaterBase.Calculate();
        }
    }
}
