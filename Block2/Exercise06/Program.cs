using System;
using System.Globalization;

namespace Exercise6
{
    public class Program
    {
        static void Main(string[] args)
        {
            string valueStr;

            while (true)
            {
                Console.WriteLine("Please enter a number (hex,binary or decimal form):");
                valueStr = Console.ReadLine();

                if (isBinary(valueStr) == true)
                {
                    int dec = BinaryToDecimal(valueStr);
                    Console.WriteLine("- Conversion to decimal is {0,3}", dec);
                    Console.WriteLine("- Conversion to hex is {0,3}\n", dec);
                }
                else if (isDecimal(valueStr) == true)
                {
                    int temp = int.Parse(valueStr);
                    Console.WriteLine("- Conversion to hex is {0,3}", DecimalToHex(temp));
                    Console.WriteLine("- Conversion to bin is {0,3}\n", DecimalToBinary(temp));
                }
                else if (isHexadecimal(valueStr) == true)
                {
                    Console.WriteLine("- Conversion to decimal is {0,3}\n", HexToDecimal(valueStr));
                }
                else
                {
                    Console.WriteLine("Error. You don't have insert a valid format.\nRetry");
                }
            }
        }

        public static string DecimalToBinary(int number)
        {
            string bin = Convert.ToString(number, 2);
            return bin;
        }

        public static int BinaryToDecimal(string number)
        {
            int dec = Convert.ToInt32(number, 2);
            return dec;
        }

        public static string DecimalToHex(int number)
        {
            string hex = number.ToString("X");
            return hex;
        }

        public static int HexToDecimal(string number)
        {
            int dec = int.Parse(number, NumberStyles.HexNumber);
            return dec;
        }

        // check if a given string contain decimal number rappresentation
        public static bool isDecimal(string str)
        {
            try
            {
                str = str.Trim();
                decimal check = decimal.Parse(str);
                return (true);
            }
            catch (FormatException)
            {
                // not a numeric value
                return (false);
            }
        }

        // check if a given string contain only hex number rappresentation 
        public static bool isHexadecimal(string str)
        {
            try
            {
                str = str.Trim();
                int check = int.Parse(str, NumberStyles.HexNumber, CultureInfo.InvariantCulture);
                return (true);
            }
            catch (FormatException)
            {
                // not a numeric value
                return (false);
            }
        }


        // check if a given string contain only bin number rappresentation
        public static bool isBinary(string str)
        {
            try
            {
                str = str.Trim();
                int bit = 0;

                for (int i = 0; i < str.Length; i++)
                {
                    // parse each char of the passed string
                    bit = int.Parse(str[i].ToString());

                    if ((bit != 1) && (bit != 0))
                    {
                        return false;
                    }

                }

                return true;
            }
            catch (FormatException)
            {
                // not a numeric value
                return (false);
            }
        }
    }
}