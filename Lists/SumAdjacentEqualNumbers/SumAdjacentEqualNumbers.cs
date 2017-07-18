
 using System;
        using System.Collections.Generic;
        using System.Linq;

    public class SumAdjacentEqualNumbers
    {
        public static void Main()
        {
            List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();
            int counter = 0;
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    counter++;
                    numbers[i] = numbers[i] + numbers[i + 1];
                    numbers.RemoveAt(i + 1);
                    i = i - 2;
                }
                if (i < 0)
                {
                    i = -1;
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }



/*

    List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();
        for (int i = 0; i < numbers.Count - 1; i++)
        {
            if (numbers[i] == numbers[i + 1])
            {

                numbers.Insert(i,numbers[i]+ numbers[i + 1]);
                numbers.RemoveAt(i + 1);
                numbers.RemoveAt(i + 1);
                i-=2;
            }
            if (i<0)
            {
                i = -1;
            }
           
            }
        Console.WriteLine(string.Join(" ", numbers));
    }
}

/*
 * List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();
    for (int i = 0; i < numbers.Count - 1; i++)
    {
        if (numbers[i] == numbers[i + 1])
        {
            numbers[i + 1] = numbers[i] + numbers[i + 1];
            numbers.RemoveAt(i);
            i=-1;
        }
        }
    Console.WriteLine(string.Join(" ", numbers));
    */