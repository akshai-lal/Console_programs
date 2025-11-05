using System;

public delegate string Reverse(string input);

public class Program
{
    public delegate String ToUpper(String input);

    public static void Main(string[] args)
    {
        ToUpper r = (input) => input.ToUpper();
        String a = "akshai";
        Console.WriteLine(r(a));
        
    }
}
