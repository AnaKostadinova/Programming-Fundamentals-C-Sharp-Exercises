using System;
using System.Collections.Generic;
using System.Linq;

class CountRealNumbers
{
    public static void Main()
    {
        double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();
        var sortedNumbers = new SortedDictionary<double, int>();

        foreach (var number in numbers)
        {
            if (!sortedNumbers.ContainsKey(number))
            {
                sortedNumbers[number] = 0;
            }
            sortedNumbers[number]++;
        }
        List<double> output = new List<double>();
        foreach (var kvp in sortedNumbers)
        {
            Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
        }
    }
}