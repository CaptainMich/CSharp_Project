using System;

namespace Exercise7
{
    public class Program
    {
        public static Random random = new Random();

        static void Main(string[] args)
        {
            int n;

            do
            {
                Console.Write("Enter an integer: ");
            } while (!Int32.TryParse(Console.ReadLine(), out n) || n <= 0);

            Console.WriteLine("Initial array is: ");
            int[] array = RandomizeArray(n);
            foreach (int e in array)
            {
                Console.Write(e + "  ");
            }
            Console.WriteLine();
        }

        public static int[] RandomizeArray(int n)
        {
            int[] array = new int[n];

            //init array from 1 to n
            for (int i = 0; i < n; i++)
            {
                array[i] = i + 1;
            }

            for (int i = 0; i < n; i++)
            {
                //swap the i-th element of the array with another one
                int temp = array[i];

                int randomIndex = random.Next(i, n);
                array[i] = array[randomIndex];

                array[randomIndex] = temp;
            }

            return array;
        }
    }
}
