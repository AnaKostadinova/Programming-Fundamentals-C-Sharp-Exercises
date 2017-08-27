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

    using System;
using System.Linq;

namespace test9
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public static Point ParsePoint(string input)
        {
            int[] inputElements = input.Split().Select(Int32.Parse).ToArray();

            return new Point(inputElements[0], inputElements[1]);
        }
    }

    public class Program
    {
        public static void Main()
        {
            Point firstPoint = Point.ParsePoint(Console.ReadLine());
            Point secondPoint = Point.ParsePoint(Console.ReadLine());

            double distance = CalcDistance(firstPoint, secondPoint);

            Console.WriteLine($"{distance:f3}");
        }

        public static double CalcDistance(Point firstPoint, Point secondPoint)
        {
            double sideA = Math.Pow((firstPoint.X - secondPoint.X), 2);
            double sideB = Math.Pow((firstPoint.Y - secondPoint.Y), 2);

            return Math.Sqrt(sideA + sideB);
        }
    }
}

    */
