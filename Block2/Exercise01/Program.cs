using System;

namespace Block2
{
    public class Program
    {
        static void Main(string[] args)
        {
            int firstInput;
            int secondInput;

            Console.WriteLine("Please enter a integer number. Press ENTER; then enter another integer and re-press ENTER:");

            while (true)
            {
                while ((int.TryParse(Console.ReadLine(), out firstInput)) && (int.TryParse(Console.ReadLine(), out secondInput)))
                {
                    Console.WriteLine("Max is: " + GetMax(firstInput, secondInput));
                    Console.WriteLine("Min is: " + GetMin(firstInput, secondInput));
                    Console.WriteLine("\n\nPlease enter two integer number");
                }

                Console.WriteLine("Error. Please enter two INTEGER number");
            }
        }

        public static int GetMin(int a, int b)
        {
            return (a + b - Math.Abs(a - b)) / 2;
        }

        public static int GetMax(int a, int b)
        {

            return (a + b + Math.Abs(a - b)) / 2;
        }
    }
}
