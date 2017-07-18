using System;
using System.Collections.Generic;
using System.Linq;

class CitiesByContinentAndCountry
{
    public static void Main()
    {
        int numberOfEntries = int.Parse(Console.ReadLine());
        Dictionary<string, Dictionary<string, List<string>>> output =
            new Dictionary<string, Dictionary<string, List<string>>>();
        for (int i = 0; i < numberOfEntries; i++)
        {
            string input = Console.ReadLine();
            string[] elements = input.Split();
            string continent = elements[0];
            string country = elements[1];
            string city = elements[2];
            if (!output.ContainsKey(continent))
            {
                output[continent] = new Dictionary<string, List<string>>();
            }
            if (!output[continent].ContainsKey(country))
            {
                output[continent][country] = new List<string>();
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