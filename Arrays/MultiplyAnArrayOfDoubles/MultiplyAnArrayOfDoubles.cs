using System;
using System.Linq;


namespace MultiplyAnArrayOfDoubles
{
    public class MultiplyAnArrayOfDoubles
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split();
            var numberArray = new double[numbers.Length];  
                       
            for (int i = 0; i <numberArray.Length; i++)
            {
                numberArray[i] = double.Parse(numbers[i]);
            }
            var p = double.Parse(Console.ReadLine());
            for (int i = 0; i < numberArray.Length; i++)
            {
                numberArray[i] *= p;
            }

            for (int i = 0; i < numberArray.Length; i++)
            {
                            Console.Write(numberArray[i]+ " ");

            }
        }
        
        }
}

/*string numbers = Console.ReadLine();
            string[] numberArray = numbers.Split();
            double[] arr = new double[numberArray.Length];
            for (int i = 0; i < numberArray.Length; i++)
            {
                arr[i] = double.Parse(numberArray[i]);
            }
            var p = double.Parse(Console.ReadLine());
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] *= p;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");

            }
        }
    }
}*/
/*
using System.Linq;
using System;
using System.Collections.Generic;

public class test
{
    public static void Main()
    {
        double[] a = Console.ReadLine().Split().Select(double.Parse).ToArray();
        double p = double.Parse(Console.ReadLine());
        double[] sum = new double[a.Length];

        for (int i = 0; i < a.Length; i++)
        {
            sum[i] = a[i] * p;
        }

        Console.WriteLine(string.Join(" ", sum));
    }
}
*/

/*
var numbers = Console.ReadLine()
.Split()
.Select(double.Parse)
.ToArray();

var p = double.Parse(Console.ReadLine());
for (int i = 0; i<numbers.Length; i++)
{
numbers[i] *= p;
}

for (int i = 0; i<numbers.Length; i++)
{
Console.Write(numbers[i] + " ");

}
}
}
}*/

