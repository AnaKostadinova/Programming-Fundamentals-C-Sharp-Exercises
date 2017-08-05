using System;
using System.Collections.Generic;
using System.Linq;


namespace CountSubstringOccurrences
{
    public class CountSubstringOccurrences
    {
        public static void Main()
        {
            string input = Console.ReadLine().ToLower();
            string symbolsToSearchFor = Console.ReadLine().ToLower();
            int counter = 0;
            int index = input.IndexOf(symbolsToSearchFor);
            while (index > -1)
            {
                index = input.IndexOf(symbolsToSearchFor, index + 1);
                counter++;
            }
            Console.WriteLine(counter);
        }
    }
}