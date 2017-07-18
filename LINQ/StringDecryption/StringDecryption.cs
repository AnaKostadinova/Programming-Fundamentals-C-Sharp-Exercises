using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;

public class StringDecryption
{
    public static void Main()
    {
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] numberSequence = Console.ReadLine().Split().Select(int.Parse).ToArray();

        numberSequence = numberSequence
            .Where(x => x >= 65 && x <= 90)
            .Skip(numbers[0])
            .Take(numbers[1])
            .ToArray();

        var a = numberSequence
            .Select(x => Convert.ToChar(x))
            .ToArray();

        Console.WriteLine(string.Join("", a));
    }
}