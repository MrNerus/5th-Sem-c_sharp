using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabActivities_5th_Sem.Control_Statements
{
    public class For_Each
    {
        public static void Entry_Point()
        {
            int len = 5;
            int[] nums = new int[len];
            for (int i = 0; i < len; i++)
            {
                Console.Write($"Enter number for index {i}: ");
                Int32.TryParse(Console.ReadLine(), out int num);
                nums[i] = num;
            }

            foreach (var num in nums)
            {
                Console.Write($"{num}, ");
            }
            Console.WriteLine("\b\b");
        }
    }
}
