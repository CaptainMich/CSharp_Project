using System;

namespace Exercise5
{
    public class Program
    {
        static void Main(string[] args)
        {
            double n;
            double x;

            Console.WriteLine("Please enter two number: N and X.\nI'll calculate for you 1 + 1!/X + 2!/X^2 + … + N!/X^N");
            Console.Write("N:");
            while (double.TryParse(Console.ReadLine(), out n))
            {
                Console.Write("X:");
                while (!double.TryParse(Console.ReadLine(), out x) || (x == 0))
                {
                    Console.WriteLine("\nError.Please enter a number different by zero!");
                    Console.Write("X:");
                }

                Console.WriteLine("Your sum is: {0:F2}", GetSum(n, x));
                Console.WriteLine("\nPlease enter two number: N and X.\nI'll calculate for you 1 + 1!/X + 2!/X^2 + … + N!/X^N");
                Console.Write("N:");
            }
        }

        public static double GetSum(double n, double x)
        {
            double result = 1;
            int factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial = 1;
                for (int j = i; j >= 1; j--)
                {
                    factorial *= j;
                }
                result += factorial / Math.Pow(x, i);
            }

            return result;
        }
    }
}
