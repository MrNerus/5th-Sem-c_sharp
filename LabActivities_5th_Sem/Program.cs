using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabActivities_5th_Sem
{
    internal class Program
    {
        /// <summary>
        ///     <qs_1>Write a C# program to show different datatypes.</qs_1>
        ///     <qs_2>Write a C# program to show implicit and explicit conversion.</qs_2>
        ///     <qs_3>Write a C# program to calculate total and percentage of multiple subjects (Arithmetic operators).</qs_3>
        ///     <qs_4>Write a C# program to show string concatenation and interpolation.</qs_4>
        ///     <qs_5>Write a C# program to pass parameter by value and pass parameter by reference.</qs_5>
        ///     <qs_6>Write a C# program to return multiple value from a method(out, ref and tuples).</qs_6>
        ///     <qs_7>Write a C# program to calculate grades based on percentage
        ///           90+ => A+
        ///           80-89 => A
        ///           70-79 => B+
        ///           60-69 => B
        ///           50-59 => C+
        ///           40-49 => C
        ///           < 40 => F
        ///     </qs_7>
        ///     <qs_8>Write a C# program to show different kinds of arrays.</qs_8>
        ///     <qs_9>Write a C# program to show concept of boxing and unboxing.</qs_9>
        ///     <qs_10>Write a program in C# Sharp to display n terms of natural number and their sum.</qs_10>
        ///     <qs_11>Write a program to input 5 numbers from users store them in array and display them using foreach loop.</qs_11>
        ///     <qs_12>Write a C# program to show different types of comments.</qs_12>
        /// </summary>
        /// <param name="args"> @args: It is ignored. </param>
        static void Main(string[] args)
        {
            /* Options हरू set गर्ने। 
             यो Key-Value Pairs को Key मा Enter गर्नपर्ने String हुन्छ। Value भनेको दुई Elements को Tuple हुन्छ।
             Value मा पहिला को index भनेको त्यो option को नाम हो। दोश्रो index भनेको त्यो option ले गर्ने काम हुन्छ। */
            Dictionary<string, Tuple<string, Action>> options = new Dictionary<string, Tuple<string, Action>>
            {
                { "1", new Tuple<string, Action>("Different Data Types", Different_Data_Types.Different_Data_Types.Entry_Point) },
                { "2", new Tuple<string, Action>("Type Conversion", Type_Conversion.Type_Conversion.Entry_Point) },
                { "3", new Tuple<string, Action>("Percentage Calculator", Arithmetic_Operators.Percentage_Calculator.Entry_Point) },
                { "4", new Tuple<string, Action>("Join Strings", String_Operations.Joins.Entry_Point) },
                { "5", new Tuple<string, Action>("Passing Parameters", Passing_Parameters.Passing_Parameters.Entry_Point) },
                { "6", new Tuple<string, Action>("Returning Methods", Returning_Methods.Returning_Methods.Entry_Point) },
                { "7", new Tuple<string, Action>("Percentage To Grades", Control_Statements.Switch_Case.Entry_Point) },
                { "8", new Tuple<string, Action>("Different Types of Array", Different_Array_Types.Different_Array_Types.Entry_Point) },
                { "9", new Tuple<string, Action>("Boxing and UnBoxing", Boxing_UnBoxing.Boxing_UnBoxing.Entry_Point) },
                { "10", new Tuple<string, Action>("Sum of n Natural Numbers", Algorithms.Natural_Numbers_Sum.Entry_Point) },
                { "11", new Tuple<string, Action>("For Each", Control_Statements.For_Each.Entry_Point) },
                { "12", new Tuple<string, Action>("Rangom Number Guessing", Game.RNG_Game.Entry_Point) },
                { "13", new Tuple<string, Action>("Inventory Management", Simulation.Inventory_Management.Entry_Point) },
                { "14", new Tuple<string, Action>("Sum of Prime Numbers in Range", Algorithms.Prime_Range.Entry_Point) },
                { "15", new Tuple<string, Action>("Add numbers untill negative", Algorithms.Add_Untill_Negative.Entry_Point) },
                { "16", new Tuple<string, Action>("Case and Length of string", String_Operations.Case_And_Length.Entry_Point) },
                { "17", new Tuple<string, Action>("Leap Year", Algorithms.Leap_Year.Entry_Point) },
                { "18", new Tuple<string, Action>("Banking System", Simulation.Simple_Bank.Entry_Point) },
                { "19", new Tuple<string, Action>("Multiplication Table", Arithmetic_Operators.Multiplication_Table.Entry_Point) },
                { "20", new Tuple<string, Action>("Geometry", Arithmetic_Operators.Geometry.Entry_Point) },
                { "21", new Tuple<string, Action>("Sum of Digits", Algorithms.Sum_Of_Digits.Entry_Point) },


            };


            // यसको काम प्रत्यक Option लाई Screen मा देखाउने र के गर्नु छ, त्यसको Input लिने हो।
            Console.WriteLine("Choose Option from below: ");
            foreach (var option in options)
            {
                Console.WriteLine($"{option.Key} : {option.Value.Item1}");
            }
            Console.Write("\n");
            Console.Write("Enter a number: ");
            var choice = Console.ReadLine();


            options[choice].Item2.Invoke();
            Console.ReadKey();
        }
    }
}
