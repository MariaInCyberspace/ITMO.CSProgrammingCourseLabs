using System;

namespace Divider
{
    class DivideIt
    {
        static void Main(string[] args)
        {
            try 
            {
                // Declaring variables of type integer
                int firstNumber, secondNumber;
                Console.WriteLine("Enter the first number, please:"); 
                firstNumber = int.Parse(Console.ReadLine()); // Store the input in the previously declared variable
                Console.WriteLine("Enter the second number, please:");
                secondNumber = int.Parse(Console.ReadLine()); // Store the input
                int divided = firstNumber / secondNumber; // Store the result of the first number divided by the second number in a new variable
                Console.WriteLine("{0} divided by {1} is {2}.", firstNumber, secondNumber, divided); 
            } 
            catch(Exception e)
            {
                Console.WriteLine("An exception was thrown: {0}", e);
            }
            
        }
    }
}
