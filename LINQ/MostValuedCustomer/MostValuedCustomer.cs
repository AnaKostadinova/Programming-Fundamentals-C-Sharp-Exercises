using System;
using System.Collections.Generic;
using System.Linq;

public class MostValuedCustomer
{
    public static void Main()
    {
        Dictionary<string, double> productPricePair = new Dictionary<string, double>();
        Dictionary<string, Dictionary<string, double>> purchases = new Dictionary<string, Dictionary<string, double>>();
        string[] input = Console.ReadLine().Split();

        while (!string.Join(" ", input).Contains("Shop is open"))
        {
            productPricePair[input[0]] = double.Parse(input[1]);

            input = Console.ReadLine().Split();
        }

        input = Console.ReadLine().Split(new char[] {' ', ',', ':'}, StringSplitOptions.RemoveEmptyEntries);
        while (input[0] != "Print")
        {
            if (input[0] == "Discount")
            {
                var pricesAfterDiscount = productPricePair
                    .OrderByDescending(kvp => kvp.Value)
                    .Take(3)
                    .Select(x => new KeyValuePair<string, double>(x.Key, x.Value * 0.10));

                foreach (var kvp in pricesAfterDiscount)
                {
                    productPricePair[kvp.Key] = kvp.Value;
                }
            }
 else
                    {
            for (int i = 0; i < 1; i++)
            {
                for (int j = 1; j < input.Length; j++)
                {
                        foreach (var kvp in productPricePair)
                        {
                            if (kvp.Key == input[j])
                            {
                                if (!purchases.ContainsKey(input[i]))
                                {
                                    purchases[input[i]] = new Dictionary<string, double>();
                                    if (!purchases[input[i]].ContainsKey(input[j]))
                                    {
                                        purchases[input[i]][input[j]] = kvp.Value;
                                    }
                                }

                                else
                                {
                                    if (!purchases[input[i]].ContainsKey(input[j]))
                                    {
                                        purchases[input[i]][input[j]] = kvp.Value;
                                    }
                                    else
                                    {
                                        purchases[input[i]][input[j]] += kvp.Value;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            input = Console.ReadLine().Split(new char[] {' ', ',', ':'}, StringSplitOptions.RemoveEmptyEntries);
        }
        var biigestSpender = purchases
            .OrderByDescending(i => i.Value.Sum(y => y.Value))
            .Take(1)
            .ToDictionary(x => x.Key, x => x.Value);

        foreach (var kvp in biigestSpender)
        {
            Console.WriteLine($"Biggest spender: {kvp.Key}\r\n^Products bought:");
            foreach (var item in kvp.Value)
            {
                Console.WriteLine($"^^^{item.Key:f2}: {item.Value:f2}");
            }
            double total = biigestSpender.Select(x => x.Value.Values.Sum()).Sum();

            Console.WriteLine($"Total: {total:f2}");
        }
    }
}