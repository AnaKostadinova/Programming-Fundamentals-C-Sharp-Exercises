using System;
using System.CodeDom;
using System.Linq;

public class CountOfCapitalLettersInArray
{
    public static void Main()
    {
        string[] words = Console.ReadLine().Split();
        int counter = 0;
        for (int i = 0; i < words.Length; i++)
        {
            string currentWord = words[i];
            if (currentWord.Length == 1)
            {
                char character = currentWord[0];
                if (character >= 65 || character <= 90)
                    counter++;
            }
        }
        Console.WriteLine(counter);
    }
}
/*using System.Linq;
using System;
using System.Collections.Generic;

public class test
{
    public static void Main()
    {
        string[] phrase = Console.ReadLine().Split();
        int counter = 0;

        for (int i = 0; i < phrase.Length; i++)
        {
            string currentWord = phrase[i];
            if (currentWord.Length == 1)
            {
                foreach (char character in currentWord)
                {
                    if (character >= 65 && character <= 90)
                    {
                        counter++;
                    }
                }
            }
        }
        Console.WriteLine(counter);
    }
}
*/