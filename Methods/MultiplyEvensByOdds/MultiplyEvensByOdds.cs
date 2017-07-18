using System;


namespace MultiplyEvensByOdds
{
    public class MultiplyEvensByOdds
    {
        public static void Main()
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));
            Console.WriteLine(GetEvenNumberSum(number));
        }

        public static int GetEvenNumberSum(int number)
        {
            int sumEvenNumbers = 0;
            int sumOddNumbers = 0;
            while (number > 0)
            {
                int lastDigit = number % 10;

                if (lastDigit % 2 == 0)
                {
                    sumEvenNumbers += lastDigit;
                }
           else
                {
                    sumOddNumbers += lastDigit;
                }
                number /= 10;

            }
            return sumOddNumbers * sumEvenNumbers;
        }
        }
    }

