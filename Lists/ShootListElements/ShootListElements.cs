using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

class ShootListElements
{
    public static void Main()
    {
        string input = Console.ReadLine();
        List<int> output = new List<int>();
        int numberToRemove = 0;
        while (input != "stop")
        {
            if (input.All(char.IsNumber))
            {
                int currentInput = int.Parse(input);
                output.Insert(0, currentInput);
            }
            if (input == "bang")
            {
                if (output.Count == 0)
                {
                    Console.WriteLine($"nobody left to shoot! last one was {numberToRemove}");
                    return;
                }
                double average = output.Average();
                for (int i = 0; i < output.Count; i++)
                {
                    if (output[i] <= average)
                    {
                        numberToRemove = output[i];
                        Console.WriteLine("shot " + numberToRemove);
                        output.Remove(numberToRemove);
                        for (int j = 0; j < output.Count; j++)
                        {
                            output[j]--;
                        }
                        break;
                    }
                }
            }
            input = Console.ReadLine();
        }
        if (output.Count > 0)
        {
            Console.WriteLine($"survivors: {string.Join(" ", output)}");
        }
        else
        {
            Console.WriteLine($"you shot them all. last one was {numberToRemove}");
        }
    }
}