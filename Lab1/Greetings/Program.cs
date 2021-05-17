using System;

namespace Greetings
{
    class Greeter
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name, please:"); // Log the message to the console
            string myName = Console.ReadLine(); // Declaring a variable of type string and store the input in a variable declared above
            Console.WriteLine("Nice to meet you, {0}!", myName); // Log the message to the console
        }
    }
}
