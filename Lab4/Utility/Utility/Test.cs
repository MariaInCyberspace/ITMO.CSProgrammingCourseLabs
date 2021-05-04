

namespace Utility
{
    using System;
    class Test
    {
        static void Main(string[] args)
        {
            int firstVariable, secondVariable, greater;

            Console.WriteLine("Enter the first number please:");
            firstVariable = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number please:");
            secondVariable = int.Parse(Console.ReadLine());
          
            greater = Utils.Greater(firstVariable, secondVariable);
            Console.WriteLine("The greater number is " + greater);
           
        }
    }
}
