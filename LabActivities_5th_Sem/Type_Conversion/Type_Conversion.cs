using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabActivities_5th_Sem.Type_Conversion
{
    public static class Type_Conversion
    {
        public static void Entry_Point()
        {
            int int_type = 5;
            double double_type = int_type;
            Console.WriteLine($"Implicit Type Casting: {int_type.GetType()} -> {double_type.GetType()}");

            var new_double = 10.5;
            var new_int = Convert.ToInt32(new_double);
            Console.WriteLine($"Explicit Type Casting: {new_double.GetType()} -> {new_int.GetType()}");

        }
    }
}
