using System;

namespace Exercise03
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string firstWord = "Hello" ;
            string secondWord = "World" ;

            // concatenation of the two string variables
            object concatenationWord = firstWord + " " + secondWord;

            Console.WriteLine("The concatenated word is " + concatenationWord + "!");
        }
    }
}
