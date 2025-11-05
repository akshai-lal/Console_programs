using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public static class StringExtension
    {
        public static String ReverseMethod(this String str)
        {
            //char[] arr=str.ToCharArray();
            //Array.Reverse(arr);
            //return new string(arr);
            String reversed = "";
            for(int i=0;i<str.Length;i++)
            {
                reversed = str[i]+reversed;
            }
            return reversed;
        }
    }

    //public class Extension
    //{
    //    public static void Main(String[] args)
    //    {
    //        String input = "akshai";
    //        Console.WriteLine(input.ReverseMethod());
    //    }
    //}
}
