using System;
using System.Collections.Generic;
using System.Linq;

public class ShortWordsSorted
{
    public static void Main()
    {
        List<string> text = Console.ReadLine()
            .ToLower()
            .Split(new char[] {'.', ',', ':', ';', '(', ')', '[', ']', '\\', '"', '\'', '/', '!', '?', ' '},
                StringSplitOptions.RemoveEmptyEntries)
            .Where(e => e.Length < 5)
            .Distinct()
            .OrderBy(e => e)
            .ToList();

        Console.WriteLine(string.Join(", ", text));
    }
}