using System;
using System.Collections.Generic;
using System.Linq;

class LargestNElements
{
    public static void Main()
    {
        List<int> a = Console.ReadLine().Split().Select(int.Parse).ToList();
        int n = int.Parse(Console.ReadLine());
        List<int> b = new List<int>();
        for (int i = 0; i < n; i++)
        {
            b.Add(a.Max());
            a.Remove(a.Max());
        }
        b.Sort();
        b.Reverse();
        Console.WriteLine(string.Join(" ", b));
    }
}
