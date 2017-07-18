using System;
using System.Collections.Generic;
using System.Linq;

public class Largest3Numbers
{
    public static void Main()
    {
        List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();

        var b = numbers.Where(a=>a>double.MinValue).OrderByDescending(a=>a).Take(3).ToList();
        Console.WriteLine(string.Join(" ", b));
    }
}

/*
 using System;
using System.Collections.Generic;
using System.Linq;

public class Largest3Numbers
{
    public static void Main()
    {
        List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();

        var b = numbers.Where(a=>a>double.MinValue).Take(3).ToList();
        Console.WriteLine(string.Join(" ", b));
    }
}
 */
