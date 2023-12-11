using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabActivities_5th_Sem.String_Operations
{
    public static class Case_And_Length
    {
        public static void Entry_Point()
        {
            Console.WriteLine("Enter a sentence: ");
            string sentence = Console.ReadLine();

            Console.WriteLine($"Upper Case Sentence: \n{sentence.ToUpper()}\n");
            Console.WriteLine($"Lower Case Sentence: \n{sentence.ToLower()}\n");
            Console.WriteLine($"This sentence has {sentence.Length} characters.");

        }
    }
}
