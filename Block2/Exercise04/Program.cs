using System;

namespace Exercise04
{
    public class Program
    {
        static void Main(string[] args)
        {
            int number;

            while (true)
            {
                do
                {
                    Console.WriteLine("Please enter a number in range (0-999). I'll convert it to word for you:");
                } while (!Int32.TryParse(Console.ReadLine(), out number) || number < 0 || number > 999);

                Console.WriteLine("Number {0} to word is: " + NumberToWords(number), number);
            }
        }

        public static string NumberToWords(int number)
        {
            string word = "";

            if (number == 0)
            {
                return "zero";
            }
            if ((number / 100) > 0)
            {
                word += NumberToWords(number / 100) + " hundred ";
                number %= 100;
            }
            if (number > 0)
            {
                if (word != "")
                {
                    word += "and";
                }

                string[] units = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
                string[] tens = { "zero", "ten", "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };

                if (number < 20)
                {
                    word += " " + units[number];
                }
                else
                {
                    word += " ";
                    word += tens[number / 10];
                    if ((number % 10) > 0)
                    {
                        word += "-" + units[number % 10];
                    }
                }
            }

            return word;
        }
    }
}