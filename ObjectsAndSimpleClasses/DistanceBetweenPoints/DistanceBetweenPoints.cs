using System;
using System.Collections.Generic;
using System.Linq;

namespace DistanceBetweenPoints
{
    public class DistanceBetweenPoints
    {
        public static void Main()
        {
            int[] firstpoinValues = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] secondpoinValues = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var firstPoint = new Point
            {
                X = firstpoinValues[0],
                Y = firstpoinValues[1]
            };
            var secondPoint = new Point
            {
                X = secondpoinValues[0],
                Y = secondpoinValues[1]
            };

            double squareX = Math.Pow(firstpoinValues[0] - secondpoinValues[0], 2);
            double squareY = Math.Pow(firstpoinValues[1] - secondpoinValues[1], 2);
            double result = Math.Sqrt(squareX + squareY);

            Console.WriteLine($"{result:f3}");
        }

        public class Point
        {
            public double X { get; set; }
            public double Y { get; set; }
        }
    }
}

/*
 * using System;
using System.Collections.Generic;
using System.Linq;

namespace DistanceBetweenPoints
{
    public class DistanceBetweenPoints
    {
        public static void Main()
        {
            int[] firstpoinValues = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] secondpoinValues = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var firstPoint = new Point
            {
                X = firstpoinValues[0],
                Y = firstpoinValues[1]
            };
            var secondPoint = new Point
            {
                X = secondpoinValues[0],
                Y = secondpoinValues[1]
            };
            double result = CalcDistance(firstPoint, secondPoint);
            Console.WriteLine($"{result:f3}");
        }

        public class Point
        {
            public double X { get; set; }
            public double Y { get; set; }
        }
        
        public static double CalcDistance(Point first, Point second)
        {
            double squareX = Math.Pow(first.X - second.X, 2);
            double squareY = Math.Pow(first.Y - second.Y, 2);
            double result = Math.Sqrt(squareX + squareY);
            return result;
        }
    }
}

    */