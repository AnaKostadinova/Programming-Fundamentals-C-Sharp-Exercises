using System;


namespace CalculateTriangleArea
{
    public class CalculateTriangleArea
    {
        public static void Main()
        {
            double triangleBase = double.Parse(Console.ReadLine()); 
            double triangleHeight = double.Parse(Console.ReadLine());
            double triangleArea = GetTriangleArea(triangleBase, triangleHeight);
            Console.WriteLine(triangleArea);

        }

        public static double GetTriangleArea(double triangleBase, double triangleHeight)
        {
           return (triangleBase * triangleHeight) / 2;
        }
    }
}