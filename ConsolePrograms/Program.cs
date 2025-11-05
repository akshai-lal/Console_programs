using ConsolePrograms;
using System;
using System.ComponentModel.DataAnnotations;
using System.Numerics;
using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;
using static program.Program;

namespace program
{
    public class Program
    {
        public static void convertDoubleToInt()
        {
        
            
            double num2 = 45.67;
            int num3 = (int)num2;
            Console.WriteLine(num3 + "all");
        }
    

        public static void squareRootOfGivenNumber()
        {
            Console.WriteLine("Enter the number");
            String num = Console.ReadLine();
            int.TryParse(num, out int num3);
            double squreroot = Math.Sqrt(num3);
            Console.WriteLine(squreroot);
        }

        public static void CheckOne()
        {
            Console.WriteLine("Enter a number");
            String num=Console.ReadLine();

            if(int.TryParse(num, out int num2))
            {
                Console.WriteLine("Valid number entered");
            }
            else
            {
                Console.WriteLine("invalid input, please enter an integer");
            }
        }

        public static void fibanccciBetweenTwoNumbers()
        {
            Console.WriteLine("Enter the first number");
            String a=Console.ReadLine();
            Console.WriteLine("Enter the second number");
            String b = Console.ReadLine();
            if(int.TryParse(a, out int num1) && int.TryParse(b, out int num2))
            {
                Console.WriteLine($"Fibanacci series between {num1} and {num2} : ");
                int first = 0;
                int second = 1;
                while(first<=num2)
                {
                   if(first>=num1)
                    {
                        Console.WriteLine(first);
                    }
                    int next = first + second;
                    first = second;
                    second = next;

                }
            }
        }

        public static void printPyramid()
        {
            int num = 35;

            for (int i = 1; i <=num; i++)
            {
                for (int space = 0; space <num - i; space++)
                {
                    Console.Write(" ");
                }

                for (int star = 0; star < i; star++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }
        }

        public static void printPyramid2()
        {
            int num = 5;
            for (int i = 1;i<=num; i++)
            {
                for(int space = 0;space <num - i; space++)
                {
                    Console.Write(" ");
                }

                for(int star = 1;star<=i;star++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine() ;
            }

            for (int i = num-1; i>=0; i--)
            {
                for (int space = 0; space < num - i; space++)
                {
                    Console.Write(" ");
                }

                for (int star = 1; star <= i; star++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }
        }

        public static int reverseAIntger()
        {
            Console.WriteLine("Enter the number");
            String a = Console.ReadLine();
            int.TryParse(a, out int num);
            int reversed = 0;
            while(num>0)
            {
                int digit = num % 10;
                reversed = reversed*10 + digit;
                num = num / 10;
            }

            return reversed;
        }


        public static void DictonaryProgram()
        {
            Dictionary<Char, int> dict= new Dictionary<Char, int>();
            dict.Add('c', 2);
            dict.Add('m', 3);
            dict['c'] = 20;
            dict.Remove('m');
            dict.Add('j', 8);
            dict.Add('n', 11);


            foreach(var d in dict)
            {
                Console.WriteLine($"letter: {d.Key}, age : {d.Value}");
            }
        }

        public static void CountLettersInAString()
        {
            String input = "akshai";
            Dictionary<Char, int> dict = new Dictionary<char, int>();
            foreach(char c in input.ToCharArray())
            {
                if(dict.ContainsKey(c))
                {
                    dict[c]++;
                }
                else
                {
                    dict[c] = 1;
                }
            }

            foreach(var d in dict)
            {
                if(d.Key=='a'|| d.Key == 'e' || d.Key == 'i' || d.Key == 'o' || d.Key == 'u')
                Console.WriteLine($"letter :{d.Key} and count : {d.Value}");
            }
        }


        public static void countNumberOfConsonants()
        {
            String s = "bcdfghjklmnpqrstvwxyz";
            Dictionary<char, int> dict = new Dictionary<char, int>();
            String input = "akshai";
            foreach(char c in input.ToCharArray())
            {
                if (s.Contains(c))
                {
                    if (dict.ContainsKey(c))
                    {
                        dict[c]++;
                    }
                    else
                    {
                        dict[c] = 1;
                    }
                }
            }

            foreach(var d in dict)
            {
                Console.WriteLine($"{d.Key} : {d.Value}");
            }
        }

        public static void fileOperations()
        {
            string path = @"C:\\Users\\Akshai.Lal\\OneDrive - Neudesic\\Desktop\akshai.txt";
            File.WriteAllText(path, "Hello, this is a file operation example!");

            String content=File.ReadAllText(path);
            Console.WriteLine(content);
        }

        public enum Weekday
            {
            Monday,Tuesday,Wednesday,Thurday,Friday,Saturday,Sunday
            }
        public static void switchStatement()
        {

            Console.WriteLine("ENTER THE DAY");
            String w=Console.ReadLine();
            switch(w)
            {
                case "Monday":
                    Console.WriteLine("First day of office");
                    break;
                case "Tuesday":
                    Console.WriteLine("second day of office");
                    break;
                case "Wednesday":
                    Console.WriteLine("third day of office");
                    break;
                default:
                    Console.WriteLine("no day");
                    break;
           }
    }

        public static void findCountOfCharacters()
        {
            String s = "akshai";
            Dictionary<char, int> dict=new Dictionary<char, int>();
            foreach(char c in s.ToCharArray())
            {
                if(dict.ContainsKey(c))
                {
                    dict[c]++;
                }
                else
                {
                    dict[c] = 1;
                }
            }

            foreach(var h in dict)
            {
                if(h.Value>1)
                {
                    Console.WriteLine($"{h.Key} {h.Value}");
                }
            }

        }


     


}
}
