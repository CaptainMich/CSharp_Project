using System;
using System.Numerics;

/*
 * Program to calculate the first 100 number of Fibonacci series.
 * To debug we used "http://www.readme.it/libri/M/M00101.shtml"
 */

namespace Exercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            int counterMax = 100;

            BigInteger[] fib = Fibonacci(counterMax);

            for (int i = 0; i < counterMax; i++)
            {
                Console.WriteLine("{0,3}: {1}", i + 1, fib[i]);
            }
        }

        public static BigInteger[] Fibonacci(int n)
        {
            BigInteger[] fib = new BigInteger[n];

            fib[0] = 0;
            fib[1] = 1;

            for (int counter = 2; counter < n; counter++)
            {
                fib[counter] = fib[counter - 1] + fib[counter - 2];
            }

            return fib;
        }
    }
}


