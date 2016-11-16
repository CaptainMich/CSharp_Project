using System;

namespace Exercise3
{
    public class Program
    {
        static void Main(string[] args)
        {
            double firstCoefficient, secondCoefficient, knownTerm;

            while (true)
            {
                do
                {
                    Console.Write("Please enter the coefficient of x^2: ");
                } while (!Double.TryParse(Console.ReadLine(), out firstCoefficient));

                do
                {
                    Console.Write("Please enter the coefficient of x^1: ");
                } while (!Double.TryParse(Console.ReadLine(), out secondCoefficient));

                do
                {
                    Console.Write("Please enter the coefficient of known term: ");
                } while (!Double.TryParse(Console.ReadLine(), out knownTerm));

                double[] roots = SolveQuadraticEq(firstCoefficient, secondCoefficient, knownTerm);

                switch (roots.Length)
                {
                    case 2:
                        Console.WriteLine("Roots are: {0:F2} and {1:F2}", roots[0], roots[1]);
                        break;
                    case 1:
                        Console.WriteLine("The single root is: {0:F2}", roots[0]);
                        break;
                    default:
                        Console.WriteLine("There aren't real roots");
                        break;
                }
            }
        }

        public static double[] SolveQuadraticEq(double a, double b, double c)
        {
            double[] roots;
            double discriminant = GetDiscriminant(a, b, c);

            if (discriminant > 0)
            {
                roots = new double[2];

                roots[0] = (-b + Math.Sqrt(discriminant)) / (2 * a);
                roots[1] = (-b - Math.Sqrt(discriminant)) / (2 * a);
            }
            else if (discriminant == 0)
            {
                roots = new double[1];

                roots[0] = (-b + Math.Sqrt(discriminant)) / (2 * a);
            }
            else
            {
                roots = new double[0];
            }

            return roots;
        }

        public static double GetDiscriminant(double a, double b, double c)
        {
            return ((b * b) - (4 * a * c));
        }
    }
}
