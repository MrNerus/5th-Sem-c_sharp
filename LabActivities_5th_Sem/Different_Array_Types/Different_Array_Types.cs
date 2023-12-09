using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabActivities_5th_Sem.Different_Array_Types
{
    public class Different_Array_Types
    {
        public static void Entry_Point()
        {
            int[] normal_array_vector = { 1, 2, 3, 4, 5 };

            int[][] jagged_array_matrix = new int[][]
            {
               new int[] {1, 2, 3},
               new int[] {4, 5, 6},
               new int[] {7, 8, 9}
            };

            int[,,] tensor = new int[3, 3, 3]
            {
               { {1,2,3}, {4,5,6}, {7,8,9} },
               { {10,11,12}, {13,14,15}, {16,17,18} },
               { {19,20,21}, {22,23,24}, {25,26,27} }
            };

            Console.WriteLine($"Accessing first value of normal array: {normal_array_vector[0]}");
            Console.WriteLine($"Accessing first value of jagged array: {jagged_array_matrix[0][0]}");
            Console.WriteLine($"Accessing first value of int[,,] array: {tensor[0,0,0]}");



        }
    }
}
