using System;
using System.Linq;
using System.Collections.Generic;

namespace Exercise9
{
    public class Program
    {
        static void Main(string[] args)
        {
            int element;
            List<int> list = new List<int>();

            Console.WriteLine("Enter array elements separeted by \\n.");
            Console.WriteLine("Invalid values will be ignored!");

            while (true)
            {
                string input = Console.ReadLine();

                if (Int32.TryParse(input, out element))
                {
                    list.Add(element);
                }
                else if (input == "q")
                {
                    break;
                }
            }

            Console.WriteLine("Your array is: ");
            foreach (int e in list)
            {
                Console.Write(e + "\t");
            }

            Console.WriteLine("\nThe longest increasing sequence is:");
            int[] longestSequence = FindLongestIncreasingSequence(list.ToArray());
            foreach (int e in longestSequence)
            {
                Console.Write(e + "\t");
            }
            Console.WriteLine();
        }

        public static int[] FindLongestIncreasingSequence(int[] array)
        {
            int[] lengthArray = FindLengthIncreasingSequence(array);

            int maxLen = lengthArray.Max();

            //There may be more than one longest increasing sequence.
            //Because the exercise doesn't provide any related specs, 
            //we return the first sequence looping array from 0 to array.Length
            int[] longest = new int[maxLen];

            //it's the last found number of the longest sequence
            int previous = Int32.MaxValue;

            for (int len = maxLen; len >= 1; len--)
            {
                //search the len-th element in the longest sequence
                for (int i = 0; i < array.Length; i++)
                {
                    int current = array[i];

                    //if the number is the len-th in array and it's smaller than previous
                    //(because we're looking for the longest INCREASING sequence)
                    if (lengthArray[i] == len && current < previous)
                    {
                        longest[len - 1] = current;
                        previous = current;
                        break;
                    }
                }
            }

            return longest;
        }

        public static int[] FindLengthIncreasingSequence(int[] array)
        {
            int length = array.Length;
            int[] lengthArray = new int[length];

            for (int i = 0; i < length; i++)
            {
                lengthArray[i] = 1;
            }

            for (int x = 1; x < length; x++)
            {
                for (int i = 0; i < x; i++)
                {
                    if (array[i] < array[x] && lengthArray[x] <= lengthArray[i])
                    {
                        lengthArray[x]++;
                    }
                }
            }

            return lengthArray;
        }
    }
}
