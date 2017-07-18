using System;
using System.Collections.Generic;
using System.Linq;

class ArrayHistogram
{
    public static void Main()
    {
        List<string> input = Console.ReadLine().Split().ToList();
        List<string> words = new List<string>();
        List<int> counts = new List<int>();

        for (int i = 0; i < input.Count; i++)
        {
            if (words.Contains(input[i]))
            {
                int index = words.IndexOf(input[i]);
                counts[index]++;
            }
            else
            {
                words.Add(input[i]);
                counts.Add(1);
            }
        }

        bool hasSwapped = true;
        while (hasSwapped)
        {
            hasSwapped = false;
            for (int i = 0; i < counts.Count - 1; i++)
            {
                if (counts[i] < counts[i + 1])
                {
                    int temp = counts[i];
                    counts[i] = counts[i + 1];
                    counts[i + 1] = temp;

                    string tempWord = words[i];
                    words[i] = words[i + 1];
                    words[i + 1] = tempWord;

                    hasSwapped = true;
                }
            }
        }

        for (int i = 0; i < counts.Count; i++)
        {
            double percentage = (double)counts[i] * 100 / input.Count;
            Console.WriteLine($"{words[i]} -> {counts[i]} times ({percentage:f2}%)");
        }
    }
}