using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabActivities_5th_Sem.Arithmetic_Operators
{
    public static class Geometry
    {
        public static void Entry_Point()
        {
            Console.Write("Enter Length of a rectangle: ");
            Double.TryParse(Console.ReadLine(), out double length);
            Console.Write("Enter Breadth of a rectangle: ");
            Double.TryParse(Console.ReadLine(), out double breadth);

            Rectangle rect = new Rectangle(length, breadth);
            Console.WriteLine($"Area of Rectangle is {rect.Area()}.");
            Console.WriteLine($"Perimeter of Rectangle is {rect.Perimeter()}.");
        }
    }

    class Rectangle
    {
        public Rectangle(double length, double breadth)
        {
            this.length = length;
            this.bredth = breadth;
        }
        double length;
        double bredth;

        public double Area() { return length * bredth; }
        public double Perimeter() { return 2 * (length + bredth); }
    }
}
