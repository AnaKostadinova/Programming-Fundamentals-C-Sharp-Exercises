using System;
using System.Linq;


namespace ArrayElementsEqualToTheirIndex
{
    public class ArrayElementsEqualToTheirIndex
    {
        public static void Main()
        {
            int days = int.Parse(Console.ReadLine());
            int doctors = 7;
            int treated = 0;
            int untreated = 0;
            for (int i = 1; i <= days; i++)
            {
                if (i % 3 == 0 && untreated > treated)
                {
                    doctors++;
                }
                int patients = int.Parse(Console.ReadLine());

                if (patients <= doctors)
                {
                    treated += patients;
                }
                else
                {
                    treated += doctors;
                    untreated += patients - doctors;
                }
            }
            Console.WriteLine($"Treated patients: {treated}.\n" +
                              $"Untreated patients: {untreated}.");
        }
    }
}
  
    

