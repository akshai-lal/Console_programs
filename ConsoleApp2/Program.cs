using System;
using System.Reflection;

public abstract class Payment
{
    public abstract void Authenticate();
    public abstract void makePayment(decimal amount);
    public void ThankYou()
    {
        Console.WriteLine("Thank you for your payment");
    }
}

public class creditcardpayment : Payment
{
    public override void Authenticate()
    {
        Console.WriteLine("Authenticating credit card");
    }
    public override void makePayment(decimal n)
    {
        Console.WriteLine("paying" + n + "via credit card");
        Console.WriteLine("Thank you for your payment");
    }
}

public class Paypalpayment : Payment
{
    public override void Authenticate()
    {
        Console.WriteLine("Authenticating Paypalpayment");
    }
    public override void makePayment(decimal n)
    {
        Console.WriteLine("paying" + n + "via paypal payment");
        Console.WriteLine("Thank you for your payment");
    }
}

public class Main()
{
    public static void main(String[] args)
    {
        int n = 500;
        Payment creditcard = new creditcardpayment();
        Payment paypal = new Paypalpayment();
        creditcard.Authenticate();
        creditcard.makePayment(n);
        paypal.Authenticate();
        paypal.makePayment(n);
    }

    public class delegates
    {

    public delegate int Operation(int a, int b);

    class Program
    {
        public static int Add(int a, int b) => a + b;
        public static int Subtract(int a, int b) => a - b;

        static void Main()
        {
            Console.WriteLine("Enter first number:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Choose operation: + or -");
            string choice = Console.ReadLine();

            Operation op;

            if (choice == "+")
                op = Add;
            else if (choice == "-")
                op = Subtract;
            else
            {
                Console.WriteLine("Invalid operation.");
                return;
            }

            int result = op(num1, num2);
            Console.WriteLine($"Result: {result}");
        }
    }
}

}


public class Student
{
    public string Name { get; set; }

    public void Greet()
    {
        Console.WriteLine($"Hello, my name is {Name}.");
    }
}

class Program
{
    public static void Main()
    {
        Type type = typeof(Student);

        object studentObj = Activator.CreateInstance(type);
        PropertyInfo nameProp = type.GetProperty("Name");
        nameProp.SetValue(studentObj, "Akshai");
        MethodInfo greetMethod = type.GetMethod("Greet");
        greetMethod.Invoke(studentObj, null);
    }
}