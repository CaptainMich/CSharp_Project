using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            System.Console.WriteLine("Enter a number and I tell you if it is a odd or even number:");

            while (int.TryParse(System.Console.ReadLine(), out number))
            {
                System.Console.Write("Your number is ");
                System.Console.WriteLine(number % 2 == 0 ? "even\n\n" : "odd\n\n");
                System.Console.WriteLine("Enter a number and I tell you if it is a odd or even number:");

            }
        }
    }
}