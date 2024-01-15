using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabActivities_5th_Sem.Classes
{
    public class Abstraction
    {
        public static void Entry_Point()
        {
            Square square = new Square(4);
            int area = square.Area();
            int perimeter = square.Perimeter();
            Console.WriteLine($"Area of Square is {area} Sq. Unit.");
            Console.WriteLine($"Perimeter of Square is {perimeter} Unit.");
        }
    }
    abstract class ShapeCompute
    {
        public abstract int Area();
        public abstract int Perimeter();
    }

    class Square : ShapeCompute
    {
        int length = 0;
        public Square(int length)
        {
            this.length = length;
        }
        public override int Area() { return length * length; }
        public override int Perimeter() { return 4 * length; }
    }
}
