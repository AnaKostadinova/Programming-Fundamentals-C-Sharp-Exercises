using System;
using System.Collections.Generic;
using System.Linq;

class DecodeRadioFrequencies
{
    public static void Main()
    {
        double[] frequencies = Console.ReadLine()
            .Split(new char[] {' ', '.'}, StringSplitOptions.RemoveEmptyEntries)
            .Select(double.Parse)
            .ToArray();

        List<char> left = new List<char>();
        List<char> right = new List<char>();

        for (int i = 0; i < frequencies.Length; i++)
        {
            if (frequencies[i] == 0)
            {
                continue;
            }
            if (i % 2 == 0)
            {
                char leftElement = (char) frequencies[i];
                left.Add(leftElement);
            }
            else
            {
                char rightElement = (char) frequencies[i];
                right.Add(rightElement);
            }
        }
        right.Reverse();
        left.AddRange(right);
        Console.WriteLine(string.Join("", left));
    }
}