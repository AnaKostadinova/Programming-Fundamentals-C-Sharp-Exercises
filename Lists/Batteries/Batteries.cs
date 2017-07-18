using System;
using System.Collections.Generic;
using System.Linq;

class Batteries
{
    public static void Main()
    {
        double[] capacity = Console.ReadLine().Split().Select(double.Parse).ToArray();
        double[] usagePerHour = Console.ReadLine().Split().Select(double.Parse).ToArray();
        int testHours = int.Parse(Console.ReadLine());
        double testCapacity = 0;
        for (
            int i = 0;
            i < capacity.Length;
            i++)
        {
            if (usagePerHour[i] * testHours < capacity[i])
            {
                testCapacity = capacity[i] - (usagePerHour[i] * testHours);
                double percentage = (testCapacity * 100) / capacity[i];
                Console.WriteLine($"Battery {i + 1}: {testCapacity:f2} mAh ({percentage:f2})%");
            }
            else
            {
                testCapacity = capacity[i] - (usagePerHour[i] * testHours);
                double hoursBatteriesLasted = (capacity[i] / usagePerHour[i]);
                Console.WriteLine($"Battery {i + 1}: " +
                                  $"dead (lasted {Math.Ceiling(hoursBatteriesLasted):f0} hours)");
            }
        }
    }
}