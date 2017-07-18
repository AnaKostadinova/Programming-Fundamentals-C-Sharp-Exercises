using System.Linq;
using System;
using System.Collections.Generic;

public class TrickyStrings
{
    public static void Main()
    {
        int[] a = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] b = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] c = new int[a.Length];
        int d = Math.Max(a.Length, b.Length);
        for (int i = 0; i < a.Length; i++)
        {
            if (a.Length == b.Length)
            {
                c[i] = a[i] + b[i];
            }
            else
            {
                {
                    c[i] = a[i % a.Length] + b[i % b.Length];
                }
            }
        }
        Console.WriteLine(string.Join(" ", c));
    }
}