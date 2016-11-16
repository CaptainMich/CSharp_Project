using System;

namespace Exercise10
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong number;

            Console.WriteLine("Please enter a positive number and I tell you if is a prime number:");

            while (ulong.TryParse(System.Console.ReadLine(), out number))
            {
                if (isPrime(number))
                {
                    Console.WriteLine("{0} is prime\n\n", number);
                }
                else
                {
                    Console.WriteLine("{0} is not prime\n\n", number);
                }

                Console.WriteLine("Please enter a positive number and I tell you if is a prime number:");
            }
        }

        public static bool isPrime(ulong number)
        {
            if (number == 1 || number == 0)
            {
                return false;
            }
            else if (number == 2)
            {
                return true;
            }

            ulong boundary = (ulong)System.Math.Floor(System.Math.Sqrt(number));

            for (ulong i = 2; i <= boundary; ++i)
            {
                if ((number % i) == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
