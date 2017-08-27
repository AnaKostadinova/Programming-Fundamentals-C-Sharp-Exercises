namespace ClosestTwoPoints
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class ClosestTwoPoints
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Point[] points = new Point[n];
            for (int i = 0; i < n; i++)
            {
                Point currentPoint = ReadPoint();
                points[i] = currentPoint;
            }
            double minDistance = double.MaxValue;
            Point minDistanceFirst = new Point();
            Point minDistanceSecond = new Point();
            for (int first = 0; first < points.Length; first++)
            {
                for (int second = first + 1; second < points.Length; second++)
                {
                    var distance = CalcDistance(points[first], points[second]);
                    if (distance < minDistance)
                    {
                        minDistance = distance;
                        minDistanceFirst = points[first];
                        minDistanceSecond = points[second];
                    }
                }
            }
            Console.WriteLine($"{minDistance:f3}");
            Console.WriteLine($"({minDistanceFirst.X}, {minDistanceFirst.Y})");
            Console.WriteLine($"({minDistanceSecond.X}, {minDistanceSecond.Y})");
        }

        public static Point ReadPoint()
        {
            var pointAsString = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            Point point = new Point();
            point.X = pointAsString[0];
            point.Y = pointAsString[1];
            return point;
        }

        public static double CalcDistance(Point firstPoint, Point secondPoint)
        {
            double diffX = Math.Pow(firstPoint.X - secondPoint.X, 2);
            double diffY = Math.Pow(firstPoint.Y - secondPoint.Y, 2);
            double distance = Math.Sqrt(diffX + diffY);
            return distance;
        }
    }
}

/*
 using System;
using System.Collections.Generic;
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
            int num = int.Parse(Console.ReadLine());

            List<Point> points = new List<Point>();
            for (int i = 0; i < num; i++)
            {
                Point currentPoint = Point.ParsePoint(Console.ReadLine());
                points.Add(currentPoint);
            }
            double minDistance = double.MaxValue;
            Point[] closestPoints = new Point[2];

            for (int i = 0; i < points.Count; i++)
            {
                for (int j = i + 1; j < points.Count; j++)
                {
                    double distance = CalcDistance(points[i], points[j]);

                    if (distance < minDistance)
                    {
                        minDistance = distance;
                        closestPoints[0] = points[i];
                        closestPoints[1] = points[j];
                    }
                }
            }
            Console.WriteLine($"{minDistance:f3}");
            Console.WriteLine($"{closestPoints[0]}");
            Console.WriteLine($"{closestPoints[1]}");
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