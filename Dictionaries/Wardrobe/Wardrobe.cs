using System;
using System.Collections.Generic;
using System.Linq;

public class SocialMediaPosts
{
    public static void Main()
    {
        Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();
        int clothes = int.Parse(Console.ReadLine());
        for (int i = 0; i < clothes; i++)
        {
            string input = Console.ReadLine();
            string[] elements = input.Split(new string[] { ",", " -> " }, StringSplitOptions.RemoveEmptyEntries);
            string colour = elements[0];

            for (int j = 1; j < elements.Length; j++)
            {
                if (!wardrobe.ContainsKey(colour))
                {
                    wardrobe[colour] = new Dictionary<string, int>();
                }
                if (!wardrobe[colour].ContainsKey(elements[j]))
                {
                    wardrobe[colour][elements[j]] = 0;
                }

                wardrobe[colour][elements[j]]++;
            }
        }

        string itemToFind = Console.ReadLine();
        string[] elementsOfItem = itemToFind.Split(' ');

        foreach (var kvp in wardrobe)
        {
            Console.WriteLine($"{kvp.Key} clothes: ");
            foreach (var pieceOfClothes in kvp.Value)
            {
                Console.Write($"* {pieceOfClothes.Key} - {pieceOfClothes.Value}");
                if (kvp.Key == elementsOfItem[0] && pieceOfClothes.Key == elementsOfItem[1])
                {
                    Console.Write(" (found!)");
                }
                Console.WriteLine();
            }
        }
    }
}