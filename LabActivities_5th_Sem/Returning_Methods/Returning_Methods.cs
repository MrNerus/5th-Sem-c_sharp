using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabActivities_5th_Sem.Returning_Methods
{
    public static class Returning_Methods
    {
        public static void Entry_Point()
        {
            Console.WriteLine(Return_Only(2));

            Out_Parameters(out int a, out int b);
            Console.WriteLine($"{a}, {b}");

            a = 2; b = 3;
            var tuple_output = Tuple_Output(a, b);
            a = tuple_output.Item1;
            b = tuple_output.Item2;
            Console.WriteLine($"{a}, {b}");

        }
        static int Return_Only(int a)
        {
            return a;
        }

        static void Out_Parameters(out int a, out int b)
        {
            a = 1;
            b = 1 + 1;
        }

        static Tuple<int, int> Tuple_Output(int a, int b)
        {
            a += 1;
            b += 1;
            return new Tuple<int, int>(a, b);
        }
    }
}
