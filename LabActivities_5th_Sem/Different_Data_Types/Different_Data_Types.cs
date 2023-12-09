using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabActivities_5th_Sem.Different_Data_Types
{
    public static class Different_Data_Types
    {
        public static void Entry_Point()
        {
            var integer_type = 1;
            var float_type = 1.1f;
            var double_type = 1.1;
            var char_type = 'A';
            var str_type = "Ard";
            var bool_type = true;

            Console.WriteLine(integer_type.GetType());
            Console.WriteLine(float_type.GetType());
            Console.WriteLine(double_type.GetType());
            Console.WriteLine(char_type.GetType());
            Console.WriteLine(str_type.GetType());
            Console.WriteLine(bool_type.GetType());

        }
    }
}
