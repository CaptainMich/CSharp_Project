using System;

namespace Exercise10
{
    public class Program
    {
        static void Main(string[] args)
        {
            int size;

            do
            {
                Console.Write("Enter the square matrix size, please: ");
            } while (!Int32.TryParse(Console.ReadLine(), out size) || size <= 0);

            Console.WriteLine("type A:");
            PrintMatrix(InitMatrixA(size));
            Console.WriteLine();

            Console.WriteLine("type B:");
            PrintMatrix(InitMatrixZigZag(size));
            Console.WriteLine();

            Console.WriteLine("type C:");
            PrintMatrix(InitMatrixDiagonal(size));
            Console.WriteLine();

            Console.WriteLine("type D:");
            PrintMatrix(InitMatrixSpiral(size));
            Console.WriteLine();
        }

        public static int[,] InitMatrixA(int size)
        {
            int[,] matrix = new int[size, size];
            int value = 1;

            for (int col = 0; col < size; col++)
            {
                for (int row = 0; row < size; row++)
                {
                    matrix[row, col] = value++;
                }
            }

            return matrix;
        }

        public static int[,] InitMatrixZigZag(int size)
        {
            int[,] matrix = new int[size, size];

            int row = 0;
            int col = 0;

            //decide if increasing(1) or decreasing(-1) row
            int flag = 1;

            for (int element = 0; element < size * size; element++)
            {
                matrix[row, col] = element + 1; //assign values from 1

                row += flag;

                if (row == size || ((row == -1) && (col != 0)))
                {
                    //pass to the next column
                    col++;

                    //invert direction of assigning values to rows
                    flag *= -1;

                    //avoid array bound exception 
                    row += flag;
                }
            }

            return matrix;
        }

        public static int[,] InitMatrixDiagonal(int size)
        {
            int[,] matrix = new int[size, size];
            int value = 1;

            //init left half of matrix (until the main diagonal)

            //start from the first column
            int lCol = 0;

            //loop all rows: start from the last row until the first one
            for (int lRow = size - 1; lRow >= 0; lRow--)
            {
                int j = lRow; //temp index of rows

                //loop all elements of the (lRow)-th diagonal
                for (int i = 0; i <= lCol;)
                {
                    //to walk on a the diagonal, we increment both indexes 
                    matrix[j++, i++] = value++;
                }

                //next diagonal will have one column more than the previous one
                lCol++;
            }


            //init right half of matrix, except the main diagonal

            //the first diagonal we loop, is the the greatest one
            int rRow = size - 1;

            //loop all column from 1 (no the main diagonal) to the last one
            for (int rCol = 1; rCol < size; rCol++)
            {
                int j = rCol;

                //loop all elements of the diagonal
                for (int i = 0; i < rRow;)
                {
                    matrix[i++, j++] = value++;
                }

                rRow--;
            }

            return matrix;
        }

        public static int[,] InitMatrixSpiral(int size)
        {
            int[,] matrix = new int[size, size];
            int el = 0;
            int colPos = 0;
            int rowPos = 0;
            int counter = 0;

            while (el < size * size)
            {
                el += GoDown(matrix, colPos, rowPos, size - counter, el);
                rowPos += (size - counter - 1);
                colPos++;

                counter++;

                if (el == (size * size))
                {
                    break;
                }

                el += GoRight(matrix, rowPos, colPos, size - counter, el);
                rowPos--;
                colPos += (size - counter - 1);

                if (el == (size * size))
                {
                    break;
                }

                el += GoUp(matrix, colPos, rowPos, size - counter, el);
                colPos--;
                rowPos -= (size - counter - 1);

                counter++;

                if (el == (size * size))
                {
                    break;
                }

                el += GoLeft(matrix, rowPos, colPos, size - counter, el);
                rowPos++;
                colPos -= (size - counter - 1);
            }

            return matrix;
        }

        public static int GoDown(int[,] matrix, int col, int rowStart, int passes, int valueStart)
        {
            for (int p = rowStart; p < rowStart + passes; p++)
            {
                matrix[p, col] = valueStart++;
            }

            return passes;
        }

        public static int GoRight(int[,] matrix, int row, int colStart, int passes, int valueStart)
        {
            for (int p = colStart; p < colStart + passes; p++)
            {
                matrix[row, p] = valueStart++;
            }

            return passes;
        }

        public static int GoUp(int[,] matrix, int col, int rowStart, int passes, int valueStart)
        {
            for (int p = rowStart; p > rowStart - passes; p--)
            {
                matrix[p, col] = valueStart++;
            }

            return passes;
        }

        public static int GoLeft(int[,] matrix, int row, int colStart, int passes, int valueStart)
        {
            for (int p = colStart; p > colStart - passes; p--)
            {
                matrix[row, p] = valueStart++;
            }

            return passes;
        }

        public static void PrintMatrix(int[,] matrix)
        {
            if (matrix == null)
            {
                return;
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                PrintLine(4, matrix.GetLength(0));

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("|");
                    Console.Write("{0,4}", matrix[row, col]);
                }
                Console.Write("|");
                Console.WriteLine();
            }

            PrintLine(4, matrix.GetLength(0));
        }

        public static void PrintLine(int elementLen, int tot)
        {
            for (int j = 0; j < tot; j++)
            {
                Console.Write("+");
                for (int i = 0; i < elementLen; i++)
                {
                    Console.Write("-");
                }
            }
            Console.Write("+");
            Console.WriteLine();
        }
    }
}
