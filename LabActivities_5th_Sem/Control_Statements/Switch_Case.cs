using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabActivities_5th_Sem.Control_Statements
{
    public class Switch_Case
    {
        public static void Entry_Point()
        {
            Console.Write("Enter the Percentage: ");
            double percentage = Convert.ToDouble(Console.ReadLine());
            string grade = "Hold";
            switch (true) 
            {
                case bool x when percentage >= 90 && percentage <= 100: grade = "A+"; break;
                case bool x when percentage >= 80 && percentage < 90:   grade = "A" ; break;
                case bool x when percentage >= 70 && percentage < 80:   grade = "B+"; break;
                case bool x when percentage >= 60 && percentage < 70:   grade = "B" ; break;
                case bool x when percentage >= 50 && percentage < 60:   grade = "C+"; break;
                case bool x when percentage >= 40 && percentage < 50:   grade = "C" ; break;
                case bool x when percentage >= 0 && percentage < 40:    grade = "F" ; break;
                default: grade = "Hold"; break;     
            }
            Console.WriteLine($"Your Grade is {grade}");
        }
    }
}
