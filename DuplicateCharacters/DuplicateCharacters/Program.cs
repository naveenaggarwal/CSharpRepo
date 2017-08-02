using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuplicateCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Call the function by passing a string for removing the duplicates");
            Console.WriteLine(RemoveduplicateChars("Google"));
            Console.ReadLine();
        }

        static string RemoveduplicateChars(string input)
        {
            string duplicates = "";

            string uniquechars = "";

            foreach(char c in input)
            {
                if (duplicates.IndexOf(c) == -1)
                {
                    duplicates = duplicates + c;
                    uniquechars = uniquechars + c;
                }
            }
            return duplicates;
        }
    }
}
