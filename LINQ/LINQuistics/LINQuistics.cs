using System;
using System.Collections.Generic;
using System.Linq;

public class LINQuistics
{
    public static void Main()
    {
        Dictionary<string, List<string>> collections = new Dictionary<string, List<string>>();
        string[] input = Console.ReadLine().Split(new[] {"()", "."}, StringSplitOptions.RemoveEmptyEntries);

        int number;

        while (input[0] != "exit")
        {
            string[] methods = input.Skip(1).ToArray();

            if (methods.Length > 0)
            {
                foreach(var item in methods) { 
                    {
                        if (!collections.ContainsKey(input[0]))
                        {
                            collections.Add(input[0], new List<string>());
                        }
                        if (!collections[input[0]].Contains(item))
                        {
                            collections[input[0]].Add(item);
                        }
                    }
                }
            }
            else if (int.TryParse(input[0], out number))
            {
                if (collections.Count > 0)
                {
                    var collectionWithMostMethods = collections
                        .OrderByDescending(x => x.Value.Count)
                        .First();

                    var output = collectionWithMostMethods.Value
                        .OrderBy(x => x.Length)
                        .Take(number);

                    foreach (var item in output)
                    {
                        Console.WriteLine($"* {item}");
                    }
                }
            }
            else if (collections.ContainsKey(input[0]))
            {
                var output = collections[input[0]]
                    .OrderByDescending(x => x.Length)
                    .ThenByDescending(x => x.Distinct().Count());
                foreach (var item in output)
                {
                    Console.WriteLine($"* {item}");
                }
            }

            input = Console.ReadLine().Split(new[] {"()", "."}, StringSplitOptions.RemoveEmptyEntries);
        }

        input = Console.ReadLine().Split();

        var outputCollections = collections
            .Where(x => x.Value.Contains(input[0]))
            .OrderByDescending(x => x.Value.Count)
            .ThenByDescending(x => x.Value.OrderBy(y => y.Length).First());

        foreach (var kvp in outputCollections)
        {
            List<string> methodsToSort = kvp.Value;
            var sortedMethods = methodsToSort
                .OrderByDescending(x => x.Length);

            Console.WriteLine($"{kvp.Key}");

            if (input[1] == "all")
            {
                foreach (var item in sortedMethods)
                {
                    Console.WriteLine($"* {item}");
                }
            }
        }
    }
}