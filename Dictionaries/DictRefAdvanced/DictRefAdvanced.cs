using System;
using System.Collections.Generic;
using System.Linq;

public class DictRefAdvanced
{
    public static void Main()
    {
        string input = Console.ReadLine();
        Dictionary<string, List<string>> refDict = new Dictionary<string, List<string>>();
        int value = 0;

        while (input != "end")
        {
            string[] elements = input.Split(new char[] {' ', '-', '>', ','}, StringSplitOptions.RemoveEmptyEntries);
            string name = elements[0];
            for (int j = 1; j < elements.Length; j++)
            {
                if (!refDict.ContainsKey(name))
                {
                    refDict[name] = new List<string>();
                    if (int.TryParse(elements[j], out value))
                    {
                        refDict[name].Add(elements[j]);
                    }
                    else
                    {
                        foreach (var key in refDict.Keys)
                        {
                            if (key == elements[j])
                            {
                                refDict[name].AddRange(refDict[key]);
                            }
                        }
                    }
                }


                else
                {
                    if (int.TryParse(elements[j], out value))
                    {
                        refDict[name].Add(elements[j]);
                    }
                    else
                    {
                        foreach (var key in refDict.Keys)
                        {
                            if (key == elements[j])
                            {
                                refDict[name].AddRange(refDict[key]);
                            }
                        }
                    }
                }
            }

            input = Console.ReadLine();
        }
        foreach (var kvp in refDict)
        {
            if (kvp.Value.Count > 0)
            {
                Console.WriteLine($"{kvp.Key} === {string.Join(", ", kvp.Value)}");
            }
        }
    }
}