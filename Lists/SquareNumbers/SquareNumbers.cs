


namespace SquareNumbers
{
using System;
using System.Collections.Generic;
using System.Linq;
    class SquareNumbers
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> squareNumbers = new List<int>();
            foreach(int num in numbers) {
                if (Math.Sqrt(num) == (int) Math.Sqrt(num))
                {
                    squareNumbers.Add(num);
                }
            }
            squareNumbers.Sort((a, b) => b.CompareTo(a));
            Console.WriteLine(string.Join(" ",squareNumbers));
        }        
        }
    }

