using System;
using System.Collections.Generic;
using System.Linq;


public class Program
{
    public static void Main()
    {
        
    double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();
foreach(double num in numbers) { 
    Console.WriteLine($"{num} => {Math.Round(num, MidpointRounding.AwayFromZero)}");
}        
}
}

