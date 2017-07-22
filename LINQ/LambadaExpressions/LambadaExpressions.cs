using System;
using System.Collections.Generic;
using System.Linq;

public class LambadaExpressions
{
    public static void Main()
    {
        Dictionary<string, Dictionary<string, string>> lambadaExpressions =
            new Dictionary<string, Dictionary<string, string>>();

        string[] input = Console.ReadLine().Split(new[] {" => ", "."}, StringSplitOptions.RemoveEmptyEntries);

        while (input[0] != "lambada")
        {
            if (input[0] == "dance")
            {
                lambadaExpressions = lambadaExpressions
                    .ToDictionary(selectors => selectors.Key, selectors => selectors.Value
                        .ToDictionary(selectorObjects => selectorObjects.Key,
                            selectorObjects => selectorObjects.Key + "." + selectorObjects.Value));
            }
            else
            {
                if (!lambadaExpressions.ContainsKey(input[0]))
                {
                    lambadaExpressions[input[0]] = new Dictionary<string, string>();
                }
                lambadaExpressions[input[0]][input[1]] = input[2];
            }
            
            input = Console.ReadLine().Split(new[] {" => ", "."}, StringSplitOptions.RemoveEmptyEntries);
        }

        foreach (var kvp in lambadaExpressions)
        {
            Console.Write($"{kvp.Key} => ");

            foreach (var item in kvp.Value)
            {
                Console.WriteLine($"{item.Key}.{item.Value}");
            }
        }
    }
}