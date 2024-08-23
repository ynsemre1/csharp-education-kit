using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager yunus = new Manager { Name = "Yunus", Salary = 1000};
            Manager yagmur = new Manager { Name = "Yagmur", Salary = 1200 };

            Manager emre = new Manager { Name = "Emre", Salary = 400 };
            Manager sena = new Manager { Name = "Sena", Salary = 450 };

            yunus.Subordinats.Add(yagmur);
            yagmur.Subordinats.Add(emre);
            emre.Subordinats.Add(sena);

            OrganisationalStructure organisationalStructure = new OrganisationalStructure(yunus);

            PayrollVisitor payrollVisitor = new PayrollVisitor();
            PayriseVisitor payriseVisitor = new PayriseVisitor();

            organisationalStructure.Accept(payrollVisitor);
            organisationalStructure.Accept(payriseVisitor);

            Console.ReadLine();
        }
    }

    class OrganisationalStructure
    {
        public EmployeeBase Employee;

        public OrganisationalStructure(EmployeeBase firstEmployee)
        {
            Employee = firstEmployee;
        }

        public void Accept(VisitorBase visitor)
        {
            Employee.Accept(visitor);
        }
    }

    abstract class EmployeeBase
    {
        public abstract void Accept(VisitorBase visitor);
        public string Name { get; set; }
        public decimal Salary { get; set; }
    }

    class Manager : EmployeeBase
    {
        public Manager()
        {
            Subordinats = new List<EmployeeBase>();
        }

        public List<EmployeeBase> Subordinats { get; set; }

        public override void Accept(VisitorBase visitor)
        {
            visitor.Visit(this);

            foreach (var employee in Subordinats)
            {
                employee.Accept(visitor);
            }
        }
    }

    class Worker : EmployeeBase
    {
        public override void Accept(VisitorBase visitor)
        {
            visitor.Visit(this);
        }
    }

    abstract class VisitorBase
    {
        public abstract void Visit(Worker worker);
        public abstract void Visit(Manager manager);
    }

    class PayrollVisitor : VisitorBase
    {
        public override void Visit(Worker worker)
        {
            Console.WriteLine("{0} paid {1}", worker.Name, worker.Salary);
        }

        public override void Visit(Manager manager)
        {
            Console.WriteLine("{0} paid {1}", manager.Name, manager.Salary);
        }
    }

    class PayriseVisitor : VisitorBase
    {
        public override void Visit(Worker worker)
        {
            Console.WriteLine("{0} salary increased to {1}", worker.Name, worker.Salary* (decimal)1.1);
        }

        public override void Visit(Manager manager)
        {
            Console.WriteLine("{0} salary increased to {1}", manager.Name, manager.Salary* (decimal)1.1);
        }
    }
}
