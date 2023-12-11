using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabActivities_5th_Sem.Arithmetic_Operators
{
    public static class Percentage_Calculator
    {
        public static void Entry_Point()
        {
            Console.Write("Enter the number of subjects: ");
            Int32.TryParse(Console.ReadLine(), out int number_of_subjects);

            Console.Write("Enter the full marks of one subject: ");
            Int32.TryParse(Console.ReadLine(), out int full_marks);

            var marks = 0;
            for (int i = 0; i < number_of_subjects; i++)
            {
                Console.Write($"Enter the marks for 'Subject {i+1}': ");
                Int32.TryParse(Console.ReadLine(), out int mark);
                marks += mark;
            }

            var percentage = ((double) marks / (full_marks * number_of_subjects)) * 100;

            Console.WriteLine($"Total Marks Obtained: {marks}%");
            Console.WriteLine($"Percentage Secured  : {percentage}%");

        }
    }
}
