using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SIMPLE ARITHMETIC");
            Console.Write("Type 1st Number: ");
            int Number1 = Int32.Parse(Console.ReadLine());
            Console.Write("Type 2nd Number: ");
            int Number2 = Int32.Parse(Console.ReadLine());
            int sum = Number1 + Number2;
            Console.WriteLine("The Result of " + Number1 + " and " + Number2 + " is: " + sum);
            Console.ReadLine();
        }
    }
}
