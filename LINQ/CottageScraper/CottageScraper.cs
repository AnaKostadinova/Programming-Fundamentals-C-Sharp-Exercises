using System;
using System.Collections.Generic;
using System.Linq;

public class CottageScraper
{
    public static void Main()
    {
        Dictionary<string, List<int>> treePricePair = new Dictionary<string, List<int>>();

        string input = Console.ReadLine();

        while (input != "chop chop")
        {
            string[] elements = input.Split(new string[] {" -> "}, StringSplitOptions.RemoveEmptyEntries);
            string treeType = elements[0];
            int trunkLength = int.Parse(elements[1]);

            if (!treePricePair.ContainsKey(treeType))
            {
                treePricePair[treeType] = new List<int>();
            }
            treePricePair[treeType].Add(trunkLength);

            input = Console.ReadLine();
        }

        string usedTreesType = Console.ReadLine();
        int minLengthNeeded = int.Parse(Console.ReadLine());

        var treesToBeUSed = treePricePair
            .Where(x => x.Key == usedTreesType)
            .ToDictionary(x => x.Key, x => x.Value);

        List<int> allLogsLenghts = new List<int>();
        List<int> usedLogsLengths = new List<int>();
        List<int> unusedLogsLengths = new List<int>();

        foreach (var kvp1 in treesToBeUSed)
        {
            foreach (var element in kvp1.Value)
            {
                if (element >= minLengthNeeded)
                {
                    usedLogsLengths.Add(element);
                }
            }
        }

        foreach (var kvp2 in treePricePair)
        {
            foreach (var unusedLogLength in kvp2.Value)
            {
                if (unusedLogLength < minLengthNeeded || kvp2.Key != usedTreesType)
                {
                    unusedLogsLengths.Add(unusedLogLength);
                }
            }
        }
        foreach (var kvp in treePricePair)
        {
            foreach (var record in kvp.Value)
            {
                allLogsLenghts.Add(record);
            }
        }

        double pricePerMeter = (double) allLogsLenghts.Sum() / (double) allLogsLenghts.Count;
        pricePerMeter = Math.Round(pricePerMeter, 2);
        double usedLogsPrice = usedLogsLengths.Sum() * pricePerMeter;
        usedLogsPrice = Math.Round(usedLogsPrice, 2);
        double unusedLogsPrice = unusedLogsLengths.Sum() * pricePerMeter * 0.25;
        unusedLogsPrice = Math.Round(unusedLogsPrice, 2);
        double usedAndUnusedLogsprice = usedLogsPrice + unusedLogsPrice;

        Console.WriteLine($"Price per meter: ${pricePerMeter:f2}\r\n" +
                          $"Used logs price: ${usedLogsPrice:f2}\r\n" +
                          $"Unused logs price: ${unusedLogsPrice:f2}\r\n" +
                          $"CottageScraper subtotal: ${usedAndUnusedLogsprice:f2}");
    }
}