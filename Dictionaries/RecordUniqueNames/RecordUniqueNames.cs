using System;
using System.Collections.Generic;
using System.Linq;

public class RecordUniqueNames
{
    public static void Main()
    {
        int numberOfEntries = int.Parse(Console.ReadLine());
        HashSet<string> names = new HashSet<string>();

        for (int i = 0; i < numberOfEntries; i++)
        {
            string currentName = Console.ReadLine();

            names.Add(currentName);
        }

        Console.WriteLine(string.Join("\n", names));
    }
}