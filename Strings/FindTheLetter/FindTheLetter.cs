using System;
using System.Collections.Generic;
using System.Linq;

namespace FindTheLetter
{
    public class FindTheLetter
    {
        public static void Main()
        {
            string text = Console.ReadLine();
            string[] letterAndOccurence = Console.ReadLine().Split();

            string letterToSearchFor = letterAndOccurence[0];
            int letterOccurence = int.Parse(letterAndOccurence[1]);
            int index = text.IndexOf(letterToSearchFor);
            int counter = 0;
            for (int i = 0; i < letterOccurence - 1; i++)
            {
                index = text.IndexOf(letterToSearchFor, index + 1);
            }
            if (index == -1)
            {
                Console.WriteLine("Find the letter yourself!");
            }
            else
            {
                Console.WriteLine(index);
            }
        }
    }
}