using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Math
    {
        public long sum(long a, long b)
        {
            return a + b;
        }

        public long mul(long a, long b)
        {
            return a *b;
        }
        public long diff(long a, long b)
        {
            return a-b;
        }

        public long div(long a, long b)
        {
            try
            {
                return a / b;
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Divide by zero");
                return 0;
            }
        }

        public long Modulus(long a, long b)
        {
            try
            {
                return a % b;
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Modulus by zero");
                return 0;
            }
        }

        public double sum(double a, double b)
        {
            return a + b;
        }

        public double mul(double a, double b)
        {
            return a * b;
        }
        public double diff(double a, double b)
        {
            return a - b;
        }

        public double div(double a, double b)
        {
            try
            {
                return a / b;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Divide by zero");
                return 0;
            }
        }

        public double Modulus(double a, double b)
        {
            try
            {
                return a % b;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Modulus by zero");
                return 0;
            }
        }

        public long sum(params long[] number)
        {
            long result = 0;
            foreach(var n in number)
            {
                result=result + n;
            }
            return result;
        }

        public double sum(params double[] number)
        {
            double result = 0;
            foreach (var n in number)
            {
                result = result + n;
            }
            return result;
        }

        public long mul(params long[] number)
        {
            long result = 1;
            foreach (var n in number)
            {
                result = result* n;
            }
            return result;
        }

        public double mul(params double[] number)
        {
            double result = 1;
            foreach (var n in number)
            {
                result = result* n;
            }
            return result;
        }

        public long sumProducts(long a, long b, out long product)
        {
            product = a * b;
            return a + b;
        }

        public double sumProducts(double a, double b, out double product)
        {
            product = a * b;
            return a + b;
        }
    }


    //public class program
    //{
    //    public static void Main(String[] args)
    //    {
    //        Math m1= new Math();
    //        //Console.WriteLine(m1.sum(37800000000L, 7800000000L));
    //        //Console.WriteLine(m1.mul(23.45, 45.78));
    //        //double product;
    //        Console.WriteLine(m1.sumProducts(23.5,45.66, out double product));
    //        Console.WriteLine(product);
    //    }
    //}
}
