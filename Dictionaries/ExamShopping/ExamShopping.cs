using System;
using System.Collections.Generic;
using System.Linq;
public class ExamShopping
{
    public static void Main()
    {
        string input = Console.ReadLine();
        Dictionary<string, int> inventory = new Dictionary<string, int>();

        while (input != "shopping time")
        {
            string[] elements = input.Split();
            string product = elements[1];
            string lastElement = elements[2];
            int quantity = 0;

            if (int.TryParse(lastElement, out quantity))
            {
                if (!inventory.ContainsKey(product))
                {
                    inventory[product] = 0;
                }
                inventory[product] += quantity;
            }
            input = Console.ReadLine();
        }

        input = Console.ReadLine();
        while (input != "exam time")
        {
            string[] elements = input.Split();
            string product = elements[1];
            int quantity = int.Parse(elements[2]);

            if (!inventory.ContainsKey(product))
            {
                Console.WriteLine($"{product} doesn't exist");
            }
            else
            {
                if (inventory[product] == 0)
                {
                    Console.WriteLine($"{product} out of stock");
                }
                if (inventory[product] <= quantity)
                {
                    inventory[product] = 0;
                }
                else
                {
                    inventory[product] -= quantity;
                }
            }
            input = Console.ReadLine();
        }
        foreach (var kvp in inventory)
        {
            if (kvp.Value != 0)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
