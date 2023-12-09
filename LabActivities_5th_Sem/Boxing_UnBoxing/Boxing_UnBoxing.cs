using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabActivities_5th_Sem.Boxing_UnBoxing
{
    public class Boxing_UnBoxing
    {
        public static void Entry_Point()
        {
            int raw_integer = 3;
            Console.WriteLine($"Normal int type: {raw_integer.GetType()}");

            object boxed_integer = raw_integer;
            Console.WriteLine($"Boxed integer type: {boxed_integer.GetType()}");

            int unboxed_integer = Convert.ToInt32(boxed_integer);
            Console.WriteLine($"Unboxed int type: {unboxed_integer.GetType()}");
        }
    }
}
