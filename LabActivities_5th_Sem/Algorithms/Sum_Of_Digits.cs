using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabActivities_5th_Sem.Algorithms
{
    public static class Sum_Of_Digits
    {
        public static void Entry_Point()
        {
            Console.Write("Enter a number: ");
            Int32.TryParse(Console.ReadLine(), out int number);
            int backup_number = number;
            int sum = 0;
            while (number != 0)
            {
                sum += number % 10;
                number = number / 10;
            }
            Console.WriteLine($"Sum of all digits of {backup_number} is {sum}");
        }
    }
}
