using System;
using System.Collections.Generic;
using System.Linq;

public class OddOccurrences
{
    public static void Main()
    {

        string[] words = Console.ReadLine()
            .ToLower()
            .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
        Dictionary<string, int> wordsAndOccurrences = new Dictionary<string, int>();

        foreach (string word in words)
        {
            if (!wordsAndOccurrences.ContainsKey(word))
            {
                wordsAndOccurrences[word] = 0;
            }
            wordsAndOccurrences[word]++;
        }
        List<string> output = new List<string>();
        foreach (var kvp in wordsAndOccurrences)
        {
            var value = kvp.Value;
            if (value % 2 != 0)
            {
                output.Add(kvp.Key);
            }
        }
        Console.WriteLine(string.Join(", ", output));
    }
}


/*
string[] words = Console.ReadLine()
    .ToLower()
    .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
Dictionary<string, int> wordsAndOccurrences = new Dictionary<string, int>();

foreach (string word in words)
{
    if (!wordsAndOccurrences.ContainsKey(word))
    {
        wordsAndOccurrences[word] = 0;
    }
    wordsAndOccurrences[word]++;
}
List<string> output = new List<string>();
foreach (var kvp in wordsAndOccurrences)
{
    if (kvp.Value % 2 != 0)
    {
        output.Add(kvp.Key);
    }
}
Console.WriteLine(string.Join(", ", output));
}
}
*/
