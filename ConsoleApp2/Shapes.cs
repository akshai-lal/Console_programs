using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Cirlce
    {
        private const float pie = 3.14f;
        public float findPerimeter(int radius)
        {
            float perimteter = 2 * pie * radius;
            return perimteter;
        }

        public float findArea(int radius)
        {
            float area = pie * radius * radius;
            return area;
        }
    }

    public class Square
    {
        public int findArea(int side)
        {
            return side * side;
        }

        public int findPerimeter(int side)
        {
            return 4 * side;
        }
    }

    public class Rectangle
    {
        public int findArea(int length, int breadth)
        {
            return length * breadth;
        }

        public int findPerimeter(int length, int breadth)
        {
            return 2 * (length + breadth);
        }
    }

    public class Studentdeatils
    {
        //public static void Main(string[] args)
        //{
        //    Cirlce c = new Cirlce();
        //    Console.WriteLine(c.findArea(3));
        //    Console.WriteLine(c.findPerimeter(3));
        //}
    }

}