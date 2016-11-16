using System;

namespace Exercise09
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            byte position;
            int mask;
            int i = 1;

            Console.WriteLine("Please enter an integer, -1 to exit:");
            Int32.TryParse(Console.ReadLine(), out number);

            while (number != -1)
            {
                Console.WriteLine("Please enter a position and I tell you what is the value of the bit in that position:");
                Byte.TryParse(Console.ReadLine(), out position);

                mask = i << position;
                Console.Write("The bit in position {0} is ", position);
                Console.Write((number & mask) != 0 ? "1\n\n" : "0\n\n");
                
                Console.WriteLine("Please enter an integer, -1 to exit:");
                Int32.TryParse(Console.ReadLine(), out number);
            }
        }
    }
}
