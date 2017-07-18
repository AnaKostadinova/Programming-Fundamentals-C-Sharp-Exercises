using System;
using System.Collections.Generic;
using System.Linq;

class ShoppingSpree
{
    public static void Main()
    {
        Dictionary<string, double> shoppingList = new Dictionary<string, double>();
        double budget = double.Parse(Console.ReadLine());
        string input = Console.ReadLine();
        while (input != "end")
        {
            string[] elements = input.Split();
            string product = elements[0];
            double price = double.Parse(elements[1]);
            if (!shoppingList.ContainsKey(product))
            {
                shoppingList[product] = 0.0;
                shoppingList[product] = price;
            }
            else
            {
                if (price < shoppingList[product])
                {
                    shoppingList[product] = price;
                }
            }

            input = Console.ReadLine();
            }

            double totalPrice = shoppingList.Values.Sum();

            shoppingList = shoppingList
                .OrderByDescending(pair => pair.Value)
                .ThenBy(pair => pair.Key.Length)
                .ToDictionary(pair => pair.Key, pair => pair.Value);

            if (totalPrice > budget)
            {
                Console.WriteLine("Need more money... Just buy banichka");
            }
            else
            {
                foreach (var kvp in shoppingList)
                {
                    Console.WriteLine($"{kvp.Key} costs {kvp.Value:f2}");
                }
            }
        }
    }