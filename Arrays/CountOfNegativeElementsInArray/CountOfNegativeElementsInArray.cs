using System;
using System.Linq;


public class CountOfNegativeElementsInArray
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        int counter = 0;
        for (int i = 0; i < n; i++)
        {
            int currentNumber = int.Parse(Console.ReadLine());
            numbers[i] = currentNumber;

            if (numbers[i] < 0)
            {
                counter++;
            }
        }
        Console.WriteLine(counter);
    }
}