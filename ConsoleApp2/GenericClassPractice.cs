using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    //public class Box<T>
    //{
    //    public T value { get; set; }
    //    public void Display()
    //    {
    //        try
    //        { 
    //            Console.WriteLine($"value :{value}, Type : {value.GetType()}");
    //        }
    //        catch( Exception ex ) 
    //        {
    //            Console.WriteLine("Exception:" + ex.Message );
    //        }
    //    }

    //    public Box(T value)
    //    {
    //        this.value = value;
    //    }

    //}

    //public class GenericClass
    //{
    //    public static void Main(String[] args)
    //    {
    //        Box<int> box = new Box<int>(19);
    //        box.Display();
    //        Box<String> box2 = new Box<String>("Hello");
    //        box2.Display();
    //    }
    //}


    public class Pair<T>
    {
        public void Swap(ref T a,ref T b)
        {
            T temp=a;
            a=b;
            b=temp;
        }

    }

    public class programz
    {
        //public static void Main(String[] args)
        //{
        //    int a = 10, b = 20;
        //    Pair<int> p = new Pair<int>();
        //    p.Swap(ref a,ref b);
        //    Console.WriteLine($"{a}, {b}");
            
        //}
    }
}
