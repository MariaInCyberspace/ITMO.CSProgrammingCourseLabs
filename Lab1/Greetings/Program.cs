using System;

namespace Greetings
{
    class Greeter
    {
        static void Main(string[] args)
        {
            string myName; // Declaring a variable of type string
            Console.WriteLine("Enter your name, please:"); // Log the message to the console
            myName = Console.ReadLine(); // Store the input in a variable declared above
            Console.WriteLine("Nice to meet you, {0}!", myName); // Log the message to the console
        }
    }
}
