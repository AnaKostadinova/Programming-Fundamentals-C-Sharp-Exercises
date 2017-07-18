using System;
using System.Collections.Generic;
using System.Linq;

class FlattenDictionary
{
    public static void Main()
    {
        Dictionary<string, Dictionary<string, string>> database = new Dictionary<string, Dictionary<string, string>>();
        Dictionary<string, Dictionary<string, string>> flattenedDatabase = new Dictionary<string, Dictionary<string, string>>();

        string input = Console.ReadLine();

        while (input != "end")
        {
            string[] elements = input.Split();
            string key = elements[0];
            string innerKey = elements[1];

            if (elements[0] == ("flatten"))
            {
                foreach (var productGroup in database)
                {
                    if (productGroup.Key == elements[1])
                    {
                        foreach (var product in productGroup.Value)
                        {
                            if (!flattenedDatabase.ContainsKey(productGroup.Key))
                            {
                                flattenedDatabase[productGroup.Key] = new Dictionary<string, string>();

                                if (!flattenedDatabase[productGroup.Key].ContainsKey(product.Key))
                                {
                                    flattenedDatabase[productGroup.Key][product.Key] = product.Value;
                                }
                            }
                            flattenedDatabase[productGroup.Key][product.Key] = product.Value;
                        }
                    }
                }
                database[innerKey] = new Dictionary<string, string>();
            }
            else
            {
                string innerValue = elements[2];

                if (!database.ContainsKey(key))
                {
                    database[key] = new Dictionary<string, string>();
                    if (!database[key].ContainsKey(innerKey))
                    {
                        database[key][innerKey] = innerValue;
                    }
                }
                database[key][innerKey] = innerValue;
            }
            input = Console.ReadLine();
        }

        var sortedDatabase = database
            .OrderByDescending(x => x.Key.Length);

        foreach (var kvp in sortedDatabase)
        {
            var nestedDictionary = kvp.Value;

            nestedDictionary = nestedDictionary
                .OrderBy(x => x.Key.Length)
                .ToDictionary(x => x.Key, x => x.Value);

            int orderNumber = 1;

            Console.WriteLine($"{kvp.Key}");

            foreach (var product in nestedDictionary)
            {
                Console.WriteLine($"{orderNumber}. {product.Key} - {product.Value}");
                orderNumber++;
            }
            foreach (var productGroup in flattenedDatabase)
            {
                if (productGroup.Key == kvp.Key)
                {
                    foreach (var product in productGroup.Value)
                    {
                        Console.WriteLine($"{orderNumber}. {product.Key}{product.Value}");
                        orderNumber++;
                    }
                }
            }
        }
    }
}