using System;

namespace Exercise08
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong number;       // tried to manage random inserts that could cause overflow( -> app crash)
            byte sum = 0;
            ushort reverse = 0;
            byte firstDigit, secondDigit, thirdDigit, lastDigit;
            ushort swappedNumber1, swappedNumber2;


            Console.WriteLine("Please enter a four digit positive number and I perform this action for you:");

            while (ulong.TryParse(Console.ReadLine(), out number))
            {
                // (1) condition to verify that user have correctly entered a four digit number
                if ((number > 9999 || number < 1000) & number != 0)
                {
                    Console.WriteLine("\nError.Please enter a four digit number and I perform this action for you:");
                }

                // (2) in case of number is 0 we have to manage an exception
                else if (number == 0 )
                {
                    Console.WriteLine("- The sum of the digits: 0");
                    Console.WriteLine("- The number in reversed order: 0000");
                    Console.WriteLine("- The number with first and latest digit reversed: 0000");
                    Console.WriteLine("- The number with second and third digit reversed: 0000\n\n");
                    Console.WriteLine("Please enter a four digit positive number and I perform this action for you:");

                }

                else
                {
                    // temp variable for each task to perform 
                    ushort numberTemp1 = (ushort)number;
                    ushort numberTemp2 = (ushort)number;
                    ushort numberTemp3 = (ushort)number;

                    // Sum of digits 
                    while (numberTemp1 != 0)
                    {
                        sum += (byte)(numberTemp1 % 10);
                        numberTemp1 /= 10;
                    }
                    Console.WriteLine("- The sum of the digits: {0}", sum);

                    // Reversed order 
                    while (numberTemp2 > 0)
                    {
                        ushort remainder = (ushort)(numberTemp2 % 10);
                        reverse = (ushort)((reverse * 10) + remainder);
                        numberTemp2 /= 10;
                    }
                    Console.WriteLine("- The number in reversed order: {0}", reverse);

                    // Gets 
                    firstDigit = (byte)((numberTemp3 / 1000) % 10);
                    secondDigit = (byte)((numberTemp3 / 100) % 10);
                    thirdDigit = (byte)((numberTemp3 / 10) % 10);
                    lastDigit = (byte)(numberTemp3 % 10);                                               
                 
                    // Swap last digit with the first one
                    swappedNumber1 = (ushort)((lastDigit * 1000) + (secondDigit * 100) + (thirdDigit * 10) + (firstDigit));
                    Console.WriteLine("- The number with first and latest digit reversed {0}", swappedNumber1);

                    // Swap second digit with third one 
                    swappedNumber2 = (ushort)((firstDigit * 1000) + (thirdDigit * 100) + (secondDigit * 10) + (lastDigit));
                    Console.WriteLine("- The number with second and third digit reversed {0}\n\n", swappedNumber2);
                    
                    // Restart 
                    Console.WriteLine("Please enter a four digit positive number and I perform this action for you:");
                }
            }
        }
    }
}
