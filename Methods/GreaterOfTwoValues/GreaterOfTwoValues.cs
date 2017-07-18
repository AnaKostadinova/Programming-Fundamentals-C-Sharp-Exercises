using System;


namespace GreaterOfTwoValues
{
    public class GreaterOfTwoValues
    {
        public static void Main()
        {
            string dataType = Console.ReadLine().ToLower();

            if (dataType == "int")
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine(GetMaxInt(a, b));
            }
            else if (dataType == "char")
            {
                char a = char.Parse(Console.ReadLine());
                char b = char.Parse(Console.ReadLine());
                Console.WriteLine(GetMaxChar(a, b));
            }
            else if (dataType == "string")
            {
                string a = Console.ReadLine();
                string b = Console.ReadLine();
                Console.WriteLine(GetMaxstring(a, b));
            }
        }

        public static int GetMaxInt(int a, int b)
        {
            return Math.Max(a, b);
        }

        public static char GetMaxChar(char a, char b)
        {
            return (char)GetMaxInt((int)a, (int)b);
        }

        public static string GetMaxstring(string a, string b)
        {
            string maxValue = "";
            if (a.CompareTo(b) > 0)
            {
                maxValue = a;
            }
            else if(a.CompareTo(b)<0)
            {
                maxValue = b;
            }
            return maxValue;
        }
        }
    }
/*using System;


namespace GreaterOfTwoValues
{
    public class GreaterOfTwoValues
    {
        public static void Main()
        {
            string dataType = Console.ReadLine().ToLower();
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            Console.WriteLine(GetMax(a,b));
        }

        public static int GetMax(int a, int b)
        {
            return Math.Max(a, b);
        }

        public static char GetMax(char a, char b)
        {
            return (char)GetMax((int)a, (int)b);
        }

        public static string GetMax(string a, string b)
        {
            string maxValue = "";
            if (a.CompareTo(b) > 0)
            {
                maxValue = a;
            }
            else if(a.CompareTo(b)<0)
            {
                maxValue = b;
            }
            return maxValue;
        }
        }
    }
    */
