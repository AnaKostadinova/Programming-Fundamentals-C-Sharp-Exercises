using System;
using System.Collections.Generic;
using System.Linq;

public class KeyKeyValueValue
{
    public static void Main()
    {
        string someKey = Console.ReadLine();
        string someValue = Console.ReadLine();
        int numberOfEntries = int.Parse(Console.ReadLine());
        Dictionary<string, List<string>> output = new Dictionary<string, List<string>>();

        for (int i = 0; i < numberOfEntries; i++)
        {
            string kvp = Console.ReadLine();
            string[] inputElements = kvp.Split(new[] {"=>", ";", " "}, StringSplitOptions.RemoveEmptyEntries);
            string keyElement = inputElements[0];

            for (int j = 1; j < inputElements.Length; j++)
            {
                if (!output.ContainsKey(keyElement))
                {
                    output[keyElement] = new List<string>();
                    j--;
                }
                else
                {
                    output[keyElement].Add(inputElements[j]);
                }
            }
        }

        foreach (var key in output)
        {
            if (key.Key.Contains(someKey))
            {
                Console.WriteLine($"{key.Key}:");
            }
            else
            {
                continue;
            }
            foreach (var a in key.Value)
            {
                if (a.Contains(someValue))
                {
                    Console.WriteLine($"-{a}");
                }
            }
        }
    }
}
