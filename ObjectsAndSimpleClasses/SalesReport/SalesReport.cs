using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;


namespace SalesReport
{
    public class Sale
    {
        public string Town { get; set; }
        public string Product { get; set; }
        public double Price { get; set; }
        public double Quantity { get; set; }
    }

    public class SalesReport
    {
        public static void Main()
        {
            int numberOfSales = int.Parse(Console.ReadLine());
            Dictionary<string, double> townSalesPair = new Dictionary<string, double>();
            for (int i = 0; i < numberOfSales; i++)
            {
                var currentSale = ReadInput();

                if (!townSalesPair.ContainsKey(currentSale.Town))
                {
                    townSalesPair[currentSale.Town] = 0;
                }
                townSalesPair[currentSale.Town] += currentSale.Price * currentSale.Quantity;
            }

            townSalesPair = townSalesPair
                .OrderBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var kvp in townSalesPair)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value:f2}");
            }
        }

        public static Sale ReadInput()
        {
            string[] input = Console.ReadLine().Split();

            Sale elements = new Sale
            {
                Town = input[0],
                Product = input[1],
                Price = double.Parse(input[2]),
                Quantity = double.Parse(input[3])
            };
            return elements;
        }
    }
}