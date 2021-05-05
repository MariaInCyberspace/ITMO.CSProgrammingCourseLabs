using System;

namespace MatrixMultiply
{
    class MatrixMultiply
    {
        static void Input(int[,] dst) // Filling the array with some values by asking user for input
        {
            for (int row = 0; row < dst.GetLength(0); row++)
            {
                for (int column = 0; column < dst.GetLength(1); column++)
                {
                    Console.WriteLine("Enter value for [{0}, {1}]: ", row, column);
                    dst[row, column] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine();
        }
        static int[,] Multiply(int[,] a, int[,] b) // A method to multiply matrices
        {
            int[,] result = new int[2, 2]; // Declaring one more two-dimensional array to hold the results of multiplying the two matrices
            for (int row = 0; row < a.GetLength(0); row++)
            {
                for (int column = 0; column < b.GetLength(1); column++)
                {
                    result[row, column] += a[row, 0] * b[0, column] + a[row, 1] * b[1, column];
                }
            }
            return result;
        }
        static void Output(int[,] result) // Log the matrix multiplication results to the console

        {
            for (int  row = 0; row < result.GetLength(0); row++)
            {
                for (int column = 0; column < result.GetLength(1); column++)
                {
                    Console.Write("{0} ", result[row, column]);
                }
                Console.WriteLine(); // To make the output look like a matrix instead of just one line
            }           
        }
        static void Main(string[] args)
        {
            int[,] a = new int[2, 2]; // Declaration of a two-dimensional array
            Input(a); // Use the Input method to fill the array with values
           
            int[,] b = new int[2, 2]; // Declaring another two-dimensional array
            Input(b); // Use the Input method again to fill the second array with input values         

            // Use the Output method to log the matrix multiplication results to the console
            // The Output method takes the result returned by the Multiply method as an argument
            Output(Multiply(a, b));            
        }
    }
}
