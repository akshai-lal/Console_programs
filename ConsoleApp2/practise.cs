using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public interface IVehicle
    {
        public abstract void StartEngine();
        public abstract void StopEngine();
        public abstract void CalculateFuelEfficiency();
    }

    public abstract class LandVehicle : IVehicle
    {
        public int FuelCapacity {  get; set; }
        public int speed { get; set; }
        public int DistanceTravelled {  get; set; }

        public virtual void StartEngine()
        {
            Console.WriteLine("Engine started");
        }
        public virtual void StopEngine()
        {
            Console.WriteLine("Engine Stopped");
        }

        public virtual void CalculateFuelEfficiency()
        {

        }

        public LandVehicle(int FuelCapacity, int speed, int DistanceTravelled)
        {
            this.FuelCapacity = FuelCapacity;
            this.speed = speed;
            this.DistanceTravelled = DistanceTravelled;
        }

    }

    public abstract class AirVehicle : IVehicle
    {
        public int FuelCapacity { get; set; }
        public int speed { get; set; }
        public int DistanceTravelled { get; set; }

        public virtual void StartEngine()
        {
            Console.WriteLine("Engine started");
        }
        public virtual void StopEngine()
        {
            Console.WriteLine("Engine started");
        }
        public virtual void CalculateFuelEfficiency()
        {

        }

        public AirVehicle(int FuelCapacity, int speed, int DistanceTravelled)
        {
            this.FuelCapacity = FuelCapacity;
            this.speed = speed;
            this.DistanceTravelled = DistanceTravelled;
        }
    }

    public class Car : LandVehicle
    {
        public Car(int FuelCapacity, int speed, int DistanceTravelled):base(FuelCapacity,speed, DistanceTravelled) 
        {
            Console.WriteLine("Car created");
        }

        public override void CalculateFuelEfficiency()
        {
            int eff = DistanceTravelled / FuelCapacity;
            Console.WriteLine(eff);
        }
    }

    public class Motorbike : LandVehicle
    {
        public Motorbike(int FuelCapacity, int speed, int DistanceTravelled) : base(FuelCapacity, speed, DistanceTravelled)
        {
            Console.WriteLine("motorbike created");
        }

        public override void CalculateFuelEfficiency()
        {
            int eff = DistanceTravelled / FuelCapacity;
            Console.WriteLine(eff);
        }
    }

    public class helicopter : LandVehicle
    {
        public helicopter(int FuelCapacity, int speed, int DistanceTravelled) : base(FuelCapacity, speed, DistanceTravelled)
        {
            Console.WriteLine("helicopter created");
        }

        public override void CalculateFuelEfficiency()
        {
            int eff = DistanceTravelled / FuelCapacity;
            Console.WriteLine(eff);
        }

    }

    public class airplane : LandVehicle
    {
        public airplane(int FuelCapacity, int speed, int DistanceTravelled) : base(FuelCapacity, speed, DistanceTravelled)
        {
            Console.WriteLine("airplane created");
        }

        public override void CalculateFuelEfficiency()
        {
            int eff = DistanceTravelled / FuelCapacity;
            Console.WriteLine(eff);
        }

    }

    //public class programpractise
    //{
    //    public static void Main(string[] args)
    //    {
    //        Car car1 = new Car(30,50,34);
    //        helicopter h1 = new helicopter(30, 50, 30);
    //        car1.StartEngine();
    //        car1.StopEngine();
    //        car1.CalculateFuelEfficiency();
    //        h1.StopEngine();
    //        h1.StartEngine();
    //        h1.CalculateFuelEfficiency();
    //    }
    //}
}
