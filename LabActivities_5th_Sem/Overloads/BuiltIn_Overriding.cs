using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabActivities_5th_Sem.Overloads
{
    internal class BuiltIn_Overriding
    {
        public static void Entry_Point()
        {
            Directory path = new Directory
            {
                Folder = "C:",
                SubFolder = "Windows",
                SubFolder2 = "System32"
            };
            Console.WriteLine($"Folder Structure is: {path.ToString()}");
        }
    }
    public class Directory
    {
        public string Folder { get; set; }
        public string SubFolder { get; set; }
        public string SubFolder2 { get; set; }
        public override string ToString()
        {
            return $"{Folder}/{SubFolder}/{SubFolder2}";
        }
    }

}
