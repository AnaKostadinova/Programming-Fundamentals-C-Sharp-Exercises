using System;
using System.Collections.Generic;
using System.Linq;

class ForumTopics
{
    public static void Main()
    {
        Dictionary<string, HashSet<string>> database = new Dictionary<string, HashSet<string>>();
        string input = Console.ReadLine();

        while (input != "filter")
        {
            string[] inputElements = input.Split(new string[] {"->", ",", " "}, StringSplitOptions.RemoveEmptyEntries);
            string topic = inputElements[0];

            for (int i = 1; i < inputElements.Length; i++)
            {
                if (!database.ContainsKey(topic))
                {
                    database[topic] = new HashSet<string>();
                    database[topic].Add(inputElements[i]);
                }
                else
                {
                    database[topic].Add(inputElements[i]);
                }
            }
            input = Console.ReadLine();
        }

        string[] filterWords = Console.ReadLine()
            .Split(new char[] {',', ' '}, StringSplitOptions.RemoveEmptyEntries);
        foreach (var kvp in database)
        {
        int areContained = 0;
            for (int i = 0; i < filterWords.Length; i++)
            {
                if (kvp.Value.Contains(filterWords[i]))
                {
                    areContained++;
                }
            }
            if (areContained == filterWords.Length)
            {
                Console.WriteLine($"{kvp.Key} | #{string.Join(", #", kvp.Value)}");
                }
            }
        
    }
}