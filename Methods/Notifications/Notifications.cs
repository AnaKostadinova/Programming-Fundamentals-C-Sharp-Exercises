using System;
using System.Collections.Generic;
using System.Linq;



    public class Program
    {
        public static void Main()
        {
            int a = int.Parse(Console.ReadLine());

            for (int i = 0; i < a; i++)
            {
                int number = int.Parse(Console.ReadLine());
                int first = number / 100;
                int second = (number / 10) % 10;
                int third = number % 10;
                string[] ones =
                {
                    "one",
                    "two",
                    "three",
                    "four",
                    "five",
                    "six",
                    "seven",
                    "eight",
                    "nine"
                };
                string[] elevenToNineteen =
                {
                    "eleven",
                    "twelve",
                    "thirteen",
                    "fourteen",
                    "fifteen",
                    "sixteen",
                    "seventeen",
                    "eighteen",
                    "nineteen"
                };
                string[] tens =
                {
                "ten",
                    "twenty",
                    "thirty",
                    "fourty",
                    "fifty",
                    "sixty",
                    "seventy",
                    "eighty",
                    "ninety"
                };

                if (first >= 1 && first <= 9)
                {
                    if (second >= 10 && second <= 90)
                    {
                        
                    }
                }

        


        }        
        }
    }
}
