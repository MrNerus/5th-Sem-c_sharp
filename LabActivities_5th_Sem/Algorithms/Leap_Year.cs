using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabActivities_5th_Sem.Algorithms
{
    public static class Leap_Year
    {
        public static void Entry_Point()
        {
            Console.Write("Enter a year: ");
            Int32.TryParse(Console.ReadLine(), out int year);
            if (year % 400 == 0)
            {
                Console.WriteLine($"The year {year} is a leap year.");
            }
            else if (year % 100 == 0)
            {
                Console.WriteLine($"The year {year} is not a leap year.");
            }
            else if (year % 4 == 0)
            {
                Console.WriteLine($"The year {year} is a leap year.");
            }
            else
            {
                Console.WriteLine($"The year {year} is not a leap year.");
            }
        }
    }
}
