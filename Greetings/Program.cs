using System;

namespace Greetings
{
    class Program
    {
        static void Main(string[] args)
        {
            string myName; // Declaring a variable of type string
            Console.WriteLine("Enter your name, please:"); // Log a message out
            myName = Console.ReadLine(); // Store the input in the previously declared variable
            Console.WriteLine("Nice to meet you, {0}!", myName); // Log the message to the console
            Console.ReadLine();
        }
    }
}
