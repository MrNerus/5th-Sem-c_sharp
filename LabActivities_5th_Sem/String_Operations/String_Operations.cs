using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabActivities_5th_Sem.String_Operations
{
    public static class String_Operations
    {
        public static void Entry_Point()
        {
            Console.Write("Enter Text 1: ");
            var text1 = Console.ReadLine();

            Console.Write("Enter Text 2: ");
            var text2 = Console.ReadLine();

            var concat = text1 + " " + text2;
            var interpolation = $"{text1} {text2}";
            Console.WriteLine($"concat: {concat}");
            Console.WriteLine($"interpolation: {interpolation}");
        }
    }
}
