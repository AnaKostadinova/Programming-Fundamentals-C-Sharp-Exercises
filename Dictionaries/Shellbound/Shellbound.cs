using System;
using System.Collections.Generic;
using System.Linq;

public class Shellbound
{
    public static void Main()
    {
        Dictionary<string, HashSet<int>> database = new Dictionary<string, HashSet<int>>();

        string input = Console.ReadLine();

        while (input != "Aggregate")
        {
            string[] elements = input.Split();
            string region = elements[0];
            int shellSize = int.Parse(elements[1]);

            if (!database.ContainsKey(region))
            {
                database[region] = new HashSet<int>();
                database[region].Add(shellSize);
            }
            else
            {
                database[region].Add(shellSize);
            }

            input = Console.ReadLine();
        }

        foreach (var kvp in database)
        {
            Console.Write($"{kvp.Key} -> ");

            double giantShellSize = kvp.Value.Sum() - (kvp.Value.Sum() / kvp.Value.Count);
            Console.Write($"{string.Join(", ", kvp.Value)} ({(int) giantShellSize})\n");
        }
    }
}