using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Employee
    {
        public int baseSalary {get;set;}
        public int bonus { get;set;}
        public virtual double calculateSalary(int baseSalary, int bonus, out int totalSalary)
        {
                totalSalary=baseSalary+bonus;
            double tax = totalSalary * .10;
            return tax;
        }

        public Employee(int baseSalary, int bonus)
        {
            this.baseSalary = baseSalary;
            this.bonus = bonus;
        }

    }

    public class Manager : Employee
    {
        public override double calculateSalary(int baseSalary, int bonus, out int totalSalary)
        {
            double newbonus = bonus + bonus * .20;
            totalSalary = baseSalary + bonus;
            double tax = totalSalary * .15;
            return tax;
        }

        public Manager(int baseSalary, int bonus):base(baseSalary, bonus) 
        {

        }
    }

    //public class program2
    //{
        //public static void Main(string[] args)
        //{
        //    Employee e=new Employee(15000,10);
        //    Manager m=new Manager(25000,10);
        //    int empTotal, mrgTotal;
        //    Console.WriteLine(e.calculateSalary(e.baseSalary, e.bonus, out empTotal));
        //    Console.WriteLine(m.calculateSalary(m.baseSalary, m.bonus, out mrgTotal));
        //}
    //}
}
