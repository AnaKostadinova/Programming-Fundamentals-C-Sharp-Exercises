using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace RectanglePosition
{
    public class Rectangle
    {
        public int Left { get; set; }
        public int Top { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public int Bottom
        {
            get
            {
                return Top + Height;
            }
        }

        public int Right
        {
            get { return Left + Width; }
        }

        public bool IsInside(Rectangle rectangle)
        {
            bool leftIsValid = rectangle.Left <= Left;
            bool topIsValid = rectangle.Top <= Top;
            bool rightIsValid = rectangle.Right >= Right;
            bool bottomIsValid = rectangle.Bottom >= Bottom;

            return leftIsValid && topIsValid && rightIsValid && bottomIsValid;
        }
    }
    
    public class RectanglePosition
    {
        public static void Main()
        {
            var firstRectangle = ReadRectangleProperties();
            var secondRectangle = ReadRectangleProperties();
            bool result = firstRectangle.IsInside(secondRectangle);

           // string  printResult = result ? "Inside" : "Not inside";

            if (result)
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Not inside");
            }
        }   
        
        public static Rectangle ReadRectangleProperties()
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Rectangle sides = new Rectangle
            {
           Left = input[0],
            Top = input[1],
           Width = input[2],
            Height = input[3]
                };
            return sides;
        }    
        }
    }

