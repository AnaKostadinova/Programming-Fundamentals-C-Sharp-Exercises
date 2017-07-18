using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
        string command = Console.ReadLine();

        var filteredList = numbers
            .Where(x => x >= numbers.Average())
            .ToList();

        if (command == "Min")
        {
            Console.WriteLine(filteredList.Min());
        }
        else if (command == "Max")
        {
            Console.WriteLine(filteredList.Max());
        }
        else
        {
            filteredList.Sort();
            Console.WriteLine(string.Join(" ", filteredList));
        }
    }
}