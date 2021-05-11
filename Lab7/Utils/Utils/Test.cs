using System;

namespace Utils
{
    public class Test
    {
        public static void Main()
        {
            string someText;
            Console.WriteLine("Type some text please: "); // Ask for input
            someText = Console.ReadLine(); // Store the input in a variable of type string
            
            // Reverse the string 
            Utils.Reverse(ref someText);

            // Log the result to the console
            Console.WriteLine(someText);
        }
    }
}
