using System;
using System.Collections.Generic;
using System.Linq;

public class IntegerInsertion
{
    public static void Main()
    {
        List<int> a = Console.ReadLine().Split().Select(int.Parse).ToList();

        string b = Console.ReadLine();

        while (b != "end")
        {
            int index = ((int) (b[0]) - 48);
            int number = int.Parse(b);
            a.Insert(index, number);
            b = Console.ReadLine();
        }
        Console.WriteLine(string.Join(" ", a));
    }
}
