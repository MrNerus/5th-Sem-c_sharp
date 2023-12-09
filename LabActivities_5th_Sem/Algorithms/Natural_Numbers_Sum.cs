using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabActivities_5th_Sem.Algorithms
{
    public static class Natural_Numbers_Sum
    {
        public static void Entry_Point()
        {
            Console.Write("Enter the number n: ");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= num; i++)                                                                              
            {
                Console.Write($"{i}, ");
            }
            Console.WriteLine("\b\b");

            int sum = (num) * (num + 1) / 2;
            Console.WriteLine($"The Sum of natural numbers upto {num} is {sum}");
        }
    }
}
