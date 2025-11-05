using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class SpeedAnalyzer
    {
        public long AddSpeed(long a, long b)
        {
            return a + b;
        }

        public long SubstractSpeed(long a, long b)
        {
            return a - b;
        }

        public long MultiplySpeed(long a, long b)
        {
            return a + b;
        }

        public long DivideSpeed(long a, long b)
        {
            try
            {
                return a / b;
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Division by zero is not allowed in speed calculation.");
                return 0;
            }
        }

        public long ModulusSpeed(long a, long b)
        {
            try
            {
                return a % b;
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Division by zero is not allowed in speed calculation.");
                return 0;
            }
        }

        public double AddSpeed(double a, double b)
        {
            return a + b;
        }

        public double MultiplySpeed(double a, double b)
        {
            return a + b;
        }

        public double DivideSpeed(double a, double b)
        {
            try
            {
                return a / b;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Division by zero is not allowed in speed calculation.");
                return 0;
            }
        }

        public double ModulusSpeed(double a, double b)
        {
            try
            {
                return a % b;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Division by zero is not allowed in speed calculation.");
                return 0;
            }
        }

        public long AddSpeed(params long[] numbers)
        {
            long result=0;
            foreach(var n in numbers)
            {
                result =n+result;
            }
            return result;
        }

        public long MultiplySpeed(params long[] numbers)
        {
            long result = 0;
            foreach (var n in numbers)
            {
                result = n*result;
            }
            return result;
        }

        public long sumProduct(long a, long b, out long product)
        {
            product = a * b;
            return a + b;
        }

        public double sumProduct(double a, double b, out double product)
        {
            product = a * b;
            return a + b;
        }
    }

    //public class program
    //{
    //    public static void Main(string[] args)
    //    {
    //        SpeedAnalyzer s=new SpeedAnalyzer();
    //        Console.WriteLine(s.AddSpeed(23.34,45.78));
    //    }
    //}
}
