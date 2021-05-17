using System;
using System.IO; // included to be able to use FileStream and StreamReader

namespace FileDetails
{
    class FileDetails
    {
        static void Summarize(char[] charArray)
        {
            int vowels = 0; int consonants = 0; int lines = 0; // Counter variables initialization
            foreach (char c in charArray) // Loop through each element in a character array
            {
                if (char.IsLetter(c)) // Look if currently checked character is a letter
                {
                    if ("AEUIOaeuio".IndexOf(c) != -1) // Look whether currently checked character is a vowel
                    {
                        vowels++;
                    } else
                    {
                        consonants++;
                    }
                } else if (c == '\n') // Check whether a character that's currently being checked is a space
                {
                    lines++;
                }
            }
            Console.WriteLine("Total number of vowels: {0}", vowels);
            Console.WriteLine("Total number of consonants: {0}", consonants);
            Console.WriteLine("Total number of lines: {0}", lines);
            Console.WriteLine("Total number of characters: {0}", charArray.Length);
        }

        static void Main(string[ ] args)
        {
            string fileName = args[0];

            FileStream stream = new FileStream(fileName, FileMode.Open);
            StreamReader reader = new StreamReader(stream);

            int size = (int)stream.Length;
            char[] contents = new char[size];

            for (int i = 0; i < size; i++)
            {
                contents[i] = (char)reader.Read();
            }

            Summarize(contents); // Call Summarize method
                   
            Console.WriteLine(args.Length); // Get the length of the array

            reader.Close(); // Close the created above StreamReader object
        }
    }
}
