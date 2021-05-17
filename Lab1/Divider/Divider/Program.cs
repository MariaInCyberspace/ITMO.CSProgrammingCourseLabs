using System;

namespace Divider
{
    class DivideIt
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number, please:"); 
            int firstNumber = int.Parse(Console.ReadLine()); // Store the input in the previously declared variable
            Console.WriteLine("Enter the second number, please:");
            int secondNumber = int.Parse(Console.ReadLine()); // Store the input

            try 
            {
            int divided = firstNumber / secondNumber; // Store the result of the first number divided by the second number in a new variable
            Console.WriteLine("{0} divided by {1} is {2}.", firstNumber, secondNumber, divided);
            }
            catch (DivideByZeroException e) 
            {
            Console.WriteLine("An exception was thrown: {0}", e);
            }
            
        }
    }
}
