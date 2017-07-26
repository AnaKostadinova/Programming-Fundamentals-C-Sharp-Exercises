using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Net;

public class RandomizeWords
{
    public static void Main()
    {
        string[] inputWords = Console.ReadLine().Split();
        var randomizedWords = new Random();
        
        for (int i = 0; i < inputWords.Length; i++)
        {
            string currentWord = inputWords[i];
            var randomPosition = randomizedWords.Next(0, inputWords.Length);

            var tempWord = inputWords[randomPosition];
            inputWords[randomPosition] = currentWord;
            inputWords[i] = tempWord;
        }
        foreach (var word in inputWords)
        {
            Console.WriteLine(word);
        }
    }
}