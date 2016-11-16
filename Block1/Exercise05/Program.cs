using System;

namespace Exercise05
{
    class Program
    {
        static void Main(string[] args)
        {
            // first solution: using third temporary variable
            int var1 = 5;
            int var2 = 10;

            Console.WriteLine("First Solution:");
            Console.WriteLine("Variable 1 is " + var1);
            Console.WriteLine("Variable 2 is " + var2);

            int oldVar1 = var1;
            var1 = var2;
            var2 = oldVar1;

            Console.WriteLine("New variable 1 value is " + var1);
            Console.WriteLine("New variable 2 value is " + var2 + "\n\n");


            // second solution: without using third variable
            int var3 = 5;
            int var4 = 10;

            Console.WriteLine("Second Solution:");
            Console.WriteLine("Variable 3 is " + var3);
            Console.WriteLine("Variable 4 is " + var4);

            var3 = var3 + var4;
            var4 = var3 - var4;
            var3 = var3 - var4;

            Console.WriteLine("New variable 3 value is " + var3);
            Console.WriteLine("New variable 4 value is " + var4 + "\n\n");
        }
    }
}
