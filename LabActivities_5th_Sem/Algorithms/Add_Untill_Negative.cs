using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LabActivities_5th_Sem.Algorithms
{
    public static class Add_Untill_Negative
    {
        public static void Entry_Point()
        {
            int sum = 0;
            while (true)
            {
                Console.Write("Enter a number: ");
                bool is_num = Int32.TryParse(Console.ReadLine(), out int num);
                if (is_num && num < 0) { break; }
                sum += num;
            }
            Console.WriteLine($"Sum of all number before this is {sum}.");
        }
    }
}
