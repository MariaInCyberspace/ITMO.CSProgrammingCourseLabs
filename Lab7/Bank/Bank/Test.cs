using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    public class Test
    {
        public static void Main()
        {
            BankAccount bernard = new BankAccount();
            bernard.Populate(100);

            BankAccount catalina = new BankAccount();
            catalina.Populate(100);

            Console.WriteLine("Before transfer: ");
            Console.WriteLine("{0} {1} {2}", bernard.Type(), bernard.Number(), bernard.Balance());
            Console.WriteLine("{0} {1} {2}", catalina.Type(), catalina.Number(), catalina.Balance());

            bernard.TransferFrom(catalina, 10);
            Console.WriteLine("{0} {1} {2}", bernard.Type(), bernard.Number(), bernard.Balance());
            Console.WriteLine("{0} {1} {2}", catalina.Type(), catalina.Number(), catalina.Balance());
        }
    }

}
