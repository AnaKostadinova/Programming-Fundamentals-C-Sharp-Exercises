using System;
using System.Collections.Generic;
using System.Linq;

public class GroupContinentsCountriesAndCities
{
    public static void Main()
    {
        int numberOfEntries = int.Parse(Console.ReadLine());
        SortedDictionary<string, SortedDictionary<string, SortedSet<string>>> output =
            new SortedDictionary<string, SortedDictionary<string, SortedSet<string>>>();
        for (int i = 0; i < numberOfEntries; i++)
        {
            string input = Console.ReadLine();
            string[] elements = input.Split();
            string continent = elements[0];
            string country = elements[1];
            string city = elements[2];
            if (!output.ContainsKey(continent))
            {
                output[continent] = new SortedDictionary<string, SortedSet<string>>();
            }
            if (!output[continent].ContainsKey(country))
            {
                output[continent][country] = new SortedSet<string>();
                output[continent][country].Add(city);
            }
            else
            {
                output[continent][country].Add(city);
            }
        }

        foreach (var country in output)
        {
            Console.WriteLine($"{country.Key}: ");

            foreach (var city in country.Value)
            {
                Console.WriteLine($"  {city.Key} -> {string.Join(", ", city.Value)}");
            }
        }
    }
}