using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ConsoleApp2
{
    public interface IShape
    {
        public double calculateArea();
        public double calculateVolume();
        public double calculatePerimeter();
    }

    public abstract class Shape_2D : IShape
    {
        public int length { get; set; }
        public int breadth { get; set; }

        public Shape_2D(int length, int breadth)
        {
            this.length = length;
            this.breadth = breadth;
        }

        public virtual double calculateArea()
        {
            return 0;
        }

        public virtual double calculatePerimeter()
        {
            return 0;
        }

        public virtual double calculateVolume()
        {
            return 0;
        }

    }

    public abstract class Shape_3D : IShape
    {

        public int length { get; set; }
        public int breadth { get; set; }
        public int height { get; set; }

        public Shape_3D(int length, int breadth, int height)
        {
            this.length = length;
            this.breadth = breadth;
            this.height = height;
        }

        public virtual double calculateArea()
        {
            return 0;
        }

        public virtual double calculatePerimeter()
        {
            return 0;
        }

        public virtual double calculateVolume()
        {
            return 0;
        }
    }

    public class Squares : Shape_2D
    {
        public Squares(int side) : base(side, side)
        {

        }

        public override double calculateArea()
        {
            return length*breadth;
        }

        public override double calculatePerimeter()
        {
            return 4 * length;
        }

    }

    public class Rectangles : Shape_2D
    {

        public Rectangles(int length, int breadth) : base(length, breadth)
        {

        }

        public override double calculateArea()
        {
            return length * breadth;
        }

        public override double calculatePerimeter()
        {
            return 2 * (length + breadth);
        }

    }

    public class Cube : Shape_3D
    {
        public Cube(int side) : base(side, side, side)
        {

        }

        public override double calculateArea()
        {
            return 6 * length * length;
        }

        public override double calculateVolume()
        {
            return length * length * length;
        }
    }

    public class Cuboid : Shape_3D
    {
        public Cuboid(int length, int breadth, int height) : base(length, breadth, height)
        {

        }

        public override double calculateArea()
        {
            return 2 * (length * breadth + breadth * height + length * height);
        }

        public override double calculateVolume()
        {
            return length * breadth * height;
        }

    }

    //public class program
    //{
        //public static void Main(string[] args)
        //{
        //    Shape_2D s = new Squares(4);
        //    Shape_2D r = new Rectangles(2, 3);
        //    Shape_3D c = new Cube(4);
        //    Shape_3D d = new Cuboid(5, 6, 7);

        //    Console.WriteLine($"squre area :{s.calculateArea()}");
        //    Console.WriteLine($"squre perimeter :{s.calculatePerimeter()}");
        //}
    //}
}
