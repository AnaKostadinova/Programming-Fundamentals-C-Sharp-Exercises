using System;


namespace MathPower
{
    public class MathPower
    {
        public static void Main()
        {
            double number = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());
            double product = GetPowerOfNumber(number, power);
            Console.WriteLine(product);
        }

        public static double GetPowerOfNumber(double number, double power)
        {
            double product = 1d;
            for (int i = 0; i < power; i++)
            {
                 product *= number;
            }
            return product;
        }
        }
    }

