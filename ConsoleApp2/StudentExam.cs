using System;
using System.Net;

namespace ConsoleApp2
{
    public class StudentExam
    {
        private String Name { get; set; }
        private String Address { get; set; }
        private double MathsMark { get; set; }
        private double PhysicsMark { get; set; }
        private double ChemistryMark { get; set; }
        private double BiologyMark { get; set; }

        public StudentExam(String name, String address, double math, double physicsMark, double biologyMark, double chemistrymark)
        {
            Name = name;
            Address = address;
            MathsMark = math;
            PhysicsMark = physicsMark;
            BiologyMark = biologyMark;
            ChemistryMark = chemistrymark;
        }

        public double GetTotalMarks()
        {
            return MathsMark + PhysicsMark + BiologyMark + ChemistryMark;
        }

        public double GetAverageMarks()
        {
            return GetTotalMarks()/4;
        }

        public double GetPercentage()
        {
            return (GetTotalMarks() / 400) * 100;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Name :{Name}");
            Console.WriteLine($"Address :{Address}");
            Console.WriteLine($"Total Mark :{GetTotalMarks():F2}");
            Console.WriteLine($"Average Mark :{GetAverageMarks():F2}");
            Console.WriteLine($"Percentage :{GetPercentage():F2}");

        }
    }

    public class StudentExamDetails
    {
       //public static void Main(String[] args)
       // {
       //     StudentExam anas = new StudentExam("anas","anas1234",30.45,100.00,50.00,75.00);
       //     anas.DisplayDetails();
       // }
        
    }
}
