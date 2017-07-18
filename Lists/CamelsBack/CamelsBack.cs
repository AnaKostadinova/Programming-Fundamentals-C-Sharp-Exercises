using System;
using System.Collections.Generic;
using System.Linq;

public class CamelsBack
{
    public static void Main()
    {
        List<int> cityBuildings = Console.ReadLine().Split().Select(int.Parse).ToList();
        int camelBackSize = int.Parse(Console.ReadLine());

        int rounds = 0;

        for (int i = 0; i < cityBuildings.Count; i++)
        {
            if (cityBuildings.Count != camelBackSize)
            {
                cityBuildings.RemoveAt(i);
                cityBuildings.RemoveAt(cityBuildings.Count - 1);
                i--;
                rounds++;
            }
        }
        if (rounds == 0)
        {
            Console.WriteLine("already stable: " + string.Join(" ", cityBuildings));
        }
        else
        {
            Console.WriteLine($"{rounds} rounds\n" +
                              $"remaining: {string.Join(" ", cityBuildings)}");
        }
    }
}