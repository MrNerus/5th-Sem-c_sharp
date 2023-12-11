using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabActivities_5th_Sem.Arithmetic_Operators
{
    public static class Multiplication_Table
    {
        public static void Entry_Point()
        {
            Console.Write("Enter a number: ");
            Int32.TryParse(Console.ReadLine(), out int number);

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{number} x {i}\t=\t {number * i}");
            }
        }
    }
}
