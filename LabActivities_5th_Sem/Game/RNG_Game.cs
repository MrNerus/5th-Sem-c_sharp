using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LabActivities_5th_Sem.Game
{
    public static class RNG_Game
    {
        public static void Entry_Point()
        {
            Random_Number_Generator random_number_gen = new Random_Number_Generator();
            int random = random_number_gen.Generator();
            bool winning_flag = false;
            while (!winning_flag)
            {
                Console.Write("Enter a number between 1 to 100: ");
                Int32.TryParse(Console.ReadLine(), out int user_input);
                switch (true)
                {
                    case bool x when user_input < random:
                        Console.WriteLine("Too Low");
                        break;
                    case bool x when user_input > random:
                        Console.WriteLine("Too High");
                        break;
                    case bool x when user_input == random:
                        Console.WriteLine("Congrats! You won!");
                        winning_flag = true;
                        break;
                    default:
                        Console.WriteLine("Invalid Move");
                        break;
                }
            }
        }

    }
    public class Random_Number_Generator
    {
        public int Generator() {
            Random my_rng = new Random();
            return my_rng.Next(1, 101);
        }
    }
}
