using System;

namespace Example1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int a = 0, b = 0;

           Console.WriteLine("Enter a value for A:");
           a = Int32.Parse(Console.ReadLine());

           Console.WriteLine("Enter a value for b:");
           b = Int32.Parse(Console.ReadLine());
           //Changing the substration sign for the multiplication one
           Console.WriteLine($"Multiplying {a} * {b} equals {AddNumbers(a,b)}");
        }

        public static int AddNumbers(int a, int b)
        {
            //Changing the operation sign, the value  will now return a multiplication instead of a substraction
            return a * b;
        }
    }
}
