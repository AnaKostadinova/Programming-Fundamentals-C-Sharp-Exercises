using System;
using System.Collections.Generic;
using System.Linq;

class MixedPhones
{
    public static void Main()
    {
        string input = Console.ReadLine();

        SortedDictionary<string, long> phonebook = new SortedDictionary<string, long>();

        while (input != "Over")
        {
            string[] elements = input.Split();
            string firstElement = elements[0];
            string secondElement = elements[elements.Length - 1];

            if (firstElement.All(char.IsLetter))
            {
                phonebook[firstElement] = long.Parse(secondElement);
            }
            else if (firstElement.All(char.IsNumber))
            {
                phonebook[secondElement] = int.Parse(firstElement);
            }
            else
            {
                phonebook[firstElement] = int.Parse(secondElement);
            }

            input = Console.ReadLine();
        }

        foreach (var kvp in phonebook)
        {
            Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
        }
    }
}