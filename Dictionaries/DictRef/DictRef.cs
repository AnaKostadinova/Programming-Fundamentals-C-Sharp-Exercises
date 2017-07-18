using System;
using System.Collections.Generic;
using System.Linq;

class DictRef
{
    public static void Main()
    {
        string input = Console.ReadLine();
        Dictionary<string, int> refDict = new Dictionary<string, int>();
        while (input != "end")
        {
            string[] elements = input.Split();
            string name = elements[0];
            string value = elements[elements.Length - 1];
            if (value.All(char.IsNumber))
            {
                refDict[name] = int.Parse(value);
            }
            else
            {
                var keys = refDict.Keys;
                foreach (var key in keys)
                {
                    if (key == value)
                    {
                        int referencedValue = refDict[key];
                        refDict[name] = referencedValue;
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            input = Console.ReadLine();
        }
        foreach (var kvp in refDict)
        {
            Console.WriteLine($"{kvp.Key} === {kvp.Value}");
        }
    }
}

/*
 string input = Console.ReadLine();
        Dictionary<string, int> refDict = new Dictionary<string, int>();
        while (input != "end")
        {
            string[] elements = input.Split();
            string name = elements[0];
            string value = elements[elements.Length - 1];
            int number = 0;
            if (int.TryParse(value, out number))
            {
                refDict[name] = number;
            }
            else
            {
                if (refDict.ContainsKey(value))
                {
                    var referencedValue = refDict[value];
                    refDict[name] = referencedValue;
                }
            }

            input = Console.ReadLine();
        }
        foreach (var kvp in refDict)
        {
            var firstEntry = kvp.Key;
            var lastEntry = kvp.Value;
            Console.WriteLine($"{firstEntry} === {lastEntry}");
        }
    }
}

    */