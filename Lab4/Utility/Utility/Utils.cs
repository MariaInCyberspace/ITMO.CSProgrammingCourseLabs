using System;
using System.Collections.Generic;
using System.Text;

namespace Utility
{
    class Utils
    {
        public static int Greater(int a, int b) // Return the greater of two intergers 
        {
            if (a > b)
            {
                return a;
            } else
            {
                return b;
            }
        }

        public static void Swap(ref int a, ref int b) // Exchange the values of two integers, passed by reference
        {
            int temp = a; // Store the value of variable a in another variable
            a = b; // Variable a now stores the value of variable b
            b = temp; // Variable b now stores the initial value of variable a
        }


        // A method to calculate the factorial of a number
        public static bool Factorial(int n, out int answer) // Return the result as an out parameter
        {
            int k; // Declare a local variable to serve as a counter
            int f;
            bool ok = true;

            // Check the input value
            if (n < 0)
                ok = false;

            try
            {
                checked
                {
                    f = 1;
                    for (k = 2; k <= n; k++) // Use for-loop to calculate the factorial of n
                    {
                        f = f * k;
                    }
                }
            }
            catch (Exception)
            {
                f = 0;
                ok = false;
            }

            answer = f; // Assign result value
            return ok; // Return to caller

        }

    }
}
