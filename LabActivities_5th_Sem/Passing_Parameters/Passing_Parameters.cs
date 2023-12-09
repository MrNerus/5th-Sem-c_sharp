using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabActivities_5th_Sem.Passing_Parameters
{
    public static class Passing_Parameters
    {
        public static void Entry_Point()
        {
            var grade = 2;

            Console.WriteLine($"Initial Value: {grade}");

            Increase_Grade_NoRef(grade);
            Console.WriteLine($"Grade without Pass By Refrence, After Method: {grade}");

            Increase_Grade_Ref(ref grade);
            Console.WriteLine($"Value with Pass By Refrence, After Method: {grade}");
        }

        static void Increase_Grade_NoRef(int grade) 
        {
            grade += 1;
            Console.WriteLine($"Value without Pass By Refrence, Inside Method: {grade}");
        }

        static void Increase_Grade_Ref(ref int grade)
        {
            grade += 1;
            Console.WriteLine($"Value with Pass By Refrence, Inside Method: {grade}");
        }
    }
}
