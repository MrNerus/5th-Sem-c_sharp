using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabActivities_5th_Sem.Algorithms
{
    public static class Prime_Range
    {
        public static void Entry_Point()
        {
            Console.WriteLine("Enter the range of number.");
            Console.Write("Minimum Inlusive Value: ");
            Int32.TryParse(Console.ReadLine(), out int min);
            Console.Write("Maximum Inclusive Value: ");
            Int32.TryParse(Console.ReadLine(), out int max);

            int[] my_arr = new int[max+1];
            for (int i = 0; i <= max; i++) { my_arr[i] = i;  }
            my_arr[0] = 0; my_arr[1] = 0;
            for (int i = 2; i <= max; i++)
            {
                if (my_arr[i] == 0) { continue; }
                for (int j = i+1; j <= max; j++)
                {
                    if (my_arr[j] % my_arr[i] == 0)
                    {
                        my_arr[j] = 0;
                    }
                }
            }
            int sum_of_prime = 0;
            for (int i = min; i <= max; i++)
            {
                if (my_arr[i] == 0) { continue; }
                Console.Write($"{my_arr[i]} ");
                sum_of_prime += my_arr[i];
            }
            Console.WriteLine($"\nThe sum of primes form {min} to {max} is {sum_of_prime}");

        }
    }
}
