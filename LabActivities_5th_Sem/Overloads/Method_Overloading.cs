using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabActivities_5th_Sem.Overloads
{
    public class Method_Overloading
    {
        public static void Entry_Point()
        {
            int sum_1 = Calcuator.Add(1, 2); // Custom overloading
            int sum_2 = Calcuator.Add(1, 2, 3); // Custom overloading
            Console.WriteLine($"{sum_1}"); // Inbuilt overloading
            Console.WriteLine("{0}", sum_2); // Inbuilt overloading
        }
    }
    public class Calcuator
    {
        public static int Add(int num_1, int num_2)
        {
            return num_1 + num_2;
        }
        public static int Add(int num_1, int num_2, int num_3)
        {
            return num_1 + num_2 + num_3;
        }
    }
}
