using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

public class DayOfWeek
{
    public static void Main()
    {
        string date = Console.ReadLine();

        string[] elements = date.Split('-');
        int year = int.Parse(elements[2]);
        int month = int.Parse(elements[1]);
        int day = int.Parse(elements[0]);
        DateTime newDate = new DateTime(year, month, day);

        var outputDate = newDate.DayOfWeek;
        Console.WriteLine(outputDate);
    }
}

/*
string date = Console.ReadLine();

        DateTime newDate = DateTime.ParseExact(date,"d-M-yyyy",CultureInfo.InvariantCulture);
        Console.WriteLine(newDate.DayOfWeek);
    }
}
*/