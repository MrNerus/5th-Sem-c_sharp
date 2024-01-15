using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabActivities_5th_Sem.Overloads
{
    public class Method_Overriding
    {
        public static void Entry_Point()
        {
            Square square = new Square(2);
            double area_of_square = square.Area();

            Triangle triangle = new Triangle(2, 3);
            double area_of_triangle = triangle.Area();

            Console.WriteLine($"Area of Square is {area_of_square} Sq. Unit");
            Console.WriteLine($"Area of triangle is {area_of_triangle} Sq. Unit");
        }
    }
    public class Shape
    {
        public int base_ = 0;
        public int height = 0;
        public virtual double Area() { return base_ * height; }
    }
    public class Square : Shape
    {
        public Square(int length)
        {
            base_ = length;
            height = length;
        }
    }
    public class Triangle : Shape
    {
        public Triangle(int base_, int height) 
        {
            this.base_ = base_;
            this.height = height;
        }
        public override double Area() { return 0.5 * base_ * height; }
    }
}
