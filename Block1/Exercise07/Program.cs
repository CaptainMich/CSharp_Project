using System;

namespace Exercise07
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            System.Console.WriteLine("Please enter an integer and I check the third bit for you:");

            while (int.TryParse(System.Console.ReadLine(), out number))
            {
                bool bit3 = (number & 8) != 0;
                System.Console.WriteLine("The third bit is {0}", bit3 ? "1\n\n" : "0\n\n");
                System.Console.WriteLine("Please enter an integer and I check the third bit for you:");

            }
        }
    }
}
