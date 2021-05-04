

namespace Utility
{
    using System;
    class Test
    {
        static void Main(string[] args)
        {
            int firstVariable, secondVariable, greater; // Declare the variables needed for the code below to work
            bool ok;
            int factorial;

            Console.WriteLine("Enter the first number please:"); // Ask user for input
            firstVariable = int.Parse(Console.ReadLine()); // Store user's input in the variable declared above
            Console.WriteLine("Enter the second number please:"); // Ask user to input another number
            secondVariable = int.Parse(Console.ReadLine()); // Store user's input
          
            greater = Utils.Greater(firstVariable, secondVariable); // Use the Greater method from Utils class to find out which number's the greatest of the two
            Console.WriteLine("The greater number is " + greater); // Log the comparison result to the console

            // Test the swap method
            Console.WriteLine("Before the swap the first number was {0} and the second one was {1}", firstVariable, secondVariable);
            Utils.Swap(ref firstVariable, ref secondVariable); // Use the method from the Utils class to swap the values of the numbers
            Console.WriteLine("After the swap the first number has a value of " + firstVariable + " and the second one is now " + secondVariable);

            // Get factorial input
            Console.WriteLine("Enter a number please: ");
            int getFactorial = int.Parse(Console.ReadLine());

            // Test the factorial function
            ok = Utils.Factorial(getFactorial, out factorial);

            if (ok) // Output results
            {
                Console.WriteLine("The factorial of {0} is {1}", getFactorial, factorial);
            }
            else
            {
                Console.WriteLine("Cannot calculate factorial of {0}", getFactorial);
            }

        }
    }
}
