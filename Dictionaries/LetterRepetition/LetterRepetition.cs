using System;
using System.Collections.Generic;
using System.Linq;

    class Program
    {
        public static void Main()
        {
            string elements = Console.ReadLine();
            Dictionary<char, int> result = new Dictionary<char, int>();

            foreach (char letter in elements)
            {
                if (!result.ContainsKey(letter))
                {
                    result[letter] = 0;
                }
                result[letter]++;
            }

            foreach (var kvp in result)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }        
       
  
