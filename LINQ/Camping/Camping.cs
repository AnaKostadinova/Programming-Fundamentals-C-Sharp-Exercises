using System;
using System.Collections.Generic;
using System.Linq;

public class Camping
{
    public static void Main()
    {
        Dictionary<string, List<KeyValuePair<string, byte>>> database =
            new Dictionary<string, List<KeyValuePair<string, byte>>>();

        string[] input = Console.ReadLine().Split();

        while (input[0] != "end")
        {
            string name = input[0];
            string camper = input[1];
            byte nights = byte.Parse(input[2]);

            if (!database.ContainsKey(name))
            {
                database[name] = new List<KeyValuePair<string, byte>>();
            }
            database[name].Add(new KeyValuePair<string, byte>(camper, nights));

            input = Console.ReadLine().Split();
        }

        database = database
            .OrderByDescending(kvp => kvp.Value.Count)
            .ThenBy(x => x.Key.Length)
            .ToDictionary(x => x.Key, x => x.Value);
        foreach (var person in database)
        {
            var camperNightsPair = person.Value;

            foreach (var item in camperNightsPair)
            {
                Console.WriteLine($"{person.Key}: {camperNightsPair.Count}");

                foreach (var element in person.Value)
                {
                    Console.WriteLine($"***{element.Key}");
                }

                List<int> b = new List<int>();

                foreach (var a in person.Value)
                {
                    b.Add(a.Value);
                }

                Console.WriteLine($"Total stay: {b.Sum()} nights");
                break;
            }
        }
    }
}