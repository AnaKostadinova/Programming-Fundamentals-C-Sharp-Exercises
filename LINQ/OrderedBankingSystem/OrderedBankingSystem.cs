using System;
using System.Collections.Generic;
using System.Linq;

public class OrderedBankingSystem
{
    public static void Main()
    {
        Dictionary<string, Dictionary<string, decimal>> accountData = new Dictionary<string, Dictionary<string, decimal>>();

        string[] input = Console.ReadLine().Split(new[] {" -> "}, StringSplitOptions.RemoveEmptyEntries);

        while (input[0] != "end")
        {
            if (!accountData.ContainsKey(input[0]))
            {
                accountData[input[0]] = new Dictionary<string, decimal>();
            }
            if (!accountData[input[0]].ContainsKey(input[1]))
            {
                accountData[input[0]][input[1]] = 0m;
                accountData[input[0]][input[1]] += decimal.Parse(input[2]);
            }
            else
            {
                accountData[input[0]][input[1]] += decimal.Parse(input[2]);
            }
            
            input = Console.ReadLine().Split(new[] {" -> "}, StringSplitOptions.RemoveEmptyEntries);
        }

        accountData = accountData
            .OrderByDescending(x => x.Value.Sum(y => y.Value))
            .ThenByDescending(x => x.Value.Max(y=>y.Value))
            .ToDictionary(x => x.Key, x => x.Value);
        
        foreach (var kvp in accountData)
        {
            var sortedAccounts = kvp.Value;

            sortedAccounts = sortedAccounts
                .OrderByDescending(x => x.Value)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var item in sortedAccounts)
            {
                Console.WriteLine($"{item.Key} -> {item.Value} ({kvp.Key})");
            }
        }
    }
}