using System;
using System.Collections.Generic;
using System.Linq;

public class RemoveNegativesAndReverse
{
    public static void Main()
    {
        List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
        List<int> num = new List<int>(numbers.Count);

        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] < 0)
            {
                numbers.RemoveAt(i);
                i--;
            }
        }
        if (numbers.Count == 0)
        {
            Console.WriteLine("empty");
        }
        else
        {
            numbers.Reverse();
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}


/*
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> positiveNumbers = new List<int>();
            int counter = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > 0)
                {
                    positiveNumbers.Add(numbers[i]);
                    counter++;
                }
            }
            if (counter == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ", positiveNumbers));
            }
        }
    }

*/
/* Console.WriteLine(string.Join(" ", Console.ReadLine().Split().Select(int
.Parse).Where(e=>e>0).Reverse()));
*/