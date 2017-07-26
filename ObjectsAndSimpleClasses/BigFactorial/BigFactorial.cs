using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

public class BigFactorial
{
    public static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        BigInteger product = 1;
        for (int i = number; i > 1; i--)
        {
            product *= i;
        }
        Console.WriteLine(product);
    }
}