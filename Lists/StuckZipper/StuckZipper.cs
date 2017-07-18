using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

public class Program
{
    static void Main(string[] args)
    {
        List<int> a = Console.ReadLine().Split().Select(int.Parse).ToList();
        List<int> b = Console.ReadLine().Split().Select(int.Parse).ToList();
        int minA = Int32.MaxValue;
        int minB = Int32.MaxValue;

        for (int i = 0; i < a.Count; i++)
        {
            minA = Math.Min(minA, Math.Abs(a[i]).ToString().Length);
        }

        for (int i = 0; i < b.Count; i++)
        {
            minB = Math.Min(minB, Math.Abs(b[i]).ToString().Length);
        }

        for (int i = 0; i < a.Count; i++)
        {
            if (Math.Abs(a[i]).ToString().Length > Math.Min(minA, minB))
            {
                a.Remove(a[i]);
                i--;
            }
        }

        for (int i = 0; i < b.Count; i++)
        {
            if (Math.Abs(b[i]).ToString().Length > Math.Min(minA, minB))
            {
                b.Remove(b[i]);
                i--;
            }
        }

        List<int> zippedSequence = new List<int>();

        for (int i = 0; i < (a.Count + b.Count); i++)
        {
            if (i < b.Count)
            {
                zippedSequence.Add(b[i]);
            }
            if (i < a.Count)
            {
                zippedSequence.Add(a[i]);
            }
        }
        Console.WriteLine(string.Join(" ", zippedSequence));
    }
}