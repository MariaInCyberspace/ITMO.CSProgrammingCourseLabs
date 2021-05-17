using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace CopyFileUpper
{
    class CopyFileUpper
    {
        public static void Main()
        {
            string sFrom;
            string sTo;

            StreamReader srFrom;
            StreamWriter swTo;

            // Get input
            Console.Write("Copy from: ");
            sFrom = Console.ReadLine();

            // Output
            Console.Write("Copy to: ");
            sTo = Console.ReadLine();

            Console.WriteLine("Copy from {0} to {1}", sFrom, sTo);
            try 
            {
                srFrom = new StreamReader(sFrom);
                swTo = new StreamWriter(sTo);

                while (srFrom.Peek() != -1)
                {
                    string sBuffer = srFrom.ReadLine();
                    sBuffer = sBuffer.ToUpper();
                    swTo.WriteLine(sBuffer);
                }
                swTo.Close();
                srFrom.Close();
            }
            catch (FileNotFoundException f) 
            {
                Console.WriteLine("Input file not found: {0}", f.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected exception: {0}", e.ToString());
            }
        }
    }
}
