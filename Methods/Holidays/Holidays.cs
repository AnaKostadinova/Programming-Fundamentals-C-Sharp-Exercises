using System;
using System.Globalization;

class HolidaysBetweenTwoDates
{
    static void Main()
    {
        string startDate = Console.ReadLine();
        DateTime dateStart = DateTime.ParseExact(startDate, "ddMMyyyy", CultureInfo.InvariantCulture);
        string endDate = Console.ReadLine();
        DateTime dateEnd = DateTime.ParseExact(endDate, "ddMMyyyy", CultureInfo.InvariantCulture);

        var holidaysCount = 0;
        for (var date = dateStart; date <= dateEnd; date.AddDays(1))
        {
            if (date.DayOfWeek == DayOfWeek.Saturday ||
                date.DayOfWeek == DayOfWeek.Sunday)
            {
                holidaysCount++;
            }
        }
        Console.WriteLine(holidaysCount);
    }
}
