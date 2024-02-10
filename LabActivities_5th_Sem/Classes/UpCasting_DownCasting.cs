using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabActivities_5th_Sem.Classes
{
    public class UpCasting_DownCasting
    {
        public static void Entry_Point()
        {
            // upcasting
            // Children class object assigned to base class object 
            Son ard = new Son { Name = "Ard", Surname = "Nerus" };
            Father father = ard;
            Console.WriteLine(father.Surname);


            // downcasting
            // parent class object assigned to children class object (Not exactly)
            Father father1 = new Son { Surname = "Ghimire", Name = "Surendra" };
            Son ard1 = father1 as Son;
            if (ard1 != null)
            {
                Console.WriteLine($"{ard1.Name} {ard1.Surname}");
            }

        }
    }
    class Father { public string Surname { get; set; }}
    class Son : Father { public string Name { get; set; }}
}
