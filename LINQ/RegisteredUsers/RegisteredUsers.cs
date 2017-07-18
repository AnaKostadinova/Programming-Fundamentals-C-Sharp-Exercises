using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

public class RegisteredUsers
{
    public static void Main()
    {
        string registry = Console.ReadLine();
        Dictionary<string, DateTime> usersData = new Dictionary<string, DateTime>();
        while (registry != "end")
        {
            string[] elements = registry.Split(new string[] {" -> "}, StringSplitOptions.RemoveEmptyEntries);
            string name = elements[0];
            DateTime date = DateTime.ParseExact(elements[1], "dd/MM/yyyy", CultureInfo.InvariantCulture);

            usersData.Add(name, date);

            registry = Console.ReadLine();
        }
        usersData = usersData
            .Reverse()
            .OrderBy(x => x.Value)
            .Take(5)
            .OrderByDescending(x => x.Value)
            .ToDictionary(x => x.Key, x => x.Value);

        foreach (var kvp in usersData)
        {
            Console.WriteLine(kvp.Key);
        }
    }
}