using System;

namespace Exercise04
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] completeName;
            string firstName, lastName;
            do
            {
                Console.Write("Complete name: ");
                completeName = Console.ReadLine().Split(' ');
                firstName = completeName[0];
                lastName = completeName[completeName.Length - 1];
            } while (completeName.Length < 2);
            
            char gender;
            do
            {
                Console.Write("Gender: ");
                gender = Char.Parse(Console.ReadLine());
            } while (gender != 'm' && gender != 'f');

            byte age;
            do
            {
                Console.Write("Age: ");
                age = Byte.Parse(Console.ReadLine());
            } while (age <= 0);

            long id;
            do
            {
                Console.Write("ID: ");
                id = Int32.Parse(Console.ReadLine());
            } while (id <= 27560000 || id >= 27569999);
            

            Console.WriteLine("\nREPORT:");
            Console.WriteLine("{0,-13}: {1}", "Complete name", firstName + " " + lastName);
            Console.WriteLine("{0,-13}: {1}", "Gender", gender == 'm' ? "male" : "female");
            Console.WriteLine("{0,-13}: {1}", "Age", age);
            Console.WriteLine("{0,-13}: {1}", "ID", id);
        }
    }
}
