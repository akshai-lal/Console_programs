using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Generic_method
    {
        public static void  CompareValues<T>(T a, T b) where T: IComparable<T>
        {
            int value=a.CompareTo(b);
            if (value>0)
            {
                Console.WriteLine($"first value {a} is greater than second value {b}");
            }
            else if (value<0)
            {
                Console.WriteLine($"first value {a} is lesser than second value {b}");
            }
            else if(value==0)
            {
                Console.WriteLine($"first value {a} and second value {b} are equal");
            }
        }

        //public static void Main(String[] args)
        //{
        //    int a = 10, b = 9;
        //    String x = "Apple", y = "Banana";
        //    CompareValues(a, b);
        //    CompareValues(x, y);
        //}
    }
}
