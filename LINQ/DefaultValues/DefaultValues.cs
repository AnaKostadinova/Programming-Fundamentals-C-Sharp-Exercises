using System;
using System.Collections.Generic;
using System.Linq;

class DefaultValues
{
    public static void Main()
    {
        Dictionary<string, string> database = new Dictionary<string, string>();
        Dictionary<string, string> sortedDatabase = new Dictionary<string, string>();

        string input = Console.ReadLine();
        List<string> keys = new List<string>();
        List<string> values = new List<string>();
        while (input != "end")
        {
            string[] elements = input.Split(new char[] {' ', '-', '>'}, StringSplitOptions.RemoveEmptyEntries);
            string key = elements[0];
            for (int i = 1; i < elements.Length; i++)
            {

                if (!database.ContainsKey(elements[0]))
                {
                    database[elements[0]] = String.Empty;
                }
                database[elements[0]] = elements[i];
            }
            input = Console.ReadLine();
        }

        string defaultValue = Console.ReadLine();

        string nullValue = "null";

        sortedDatabase = database
            .Where(pair => pair.Value == nullValue)
            .ToDictionary(pair => pair.Key, pair => pair.Value);

    }
}




