using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabActivities_5th_Sem.Overloads
{
    public class Operator_Overloading
    {
        public static void Entry_Point()
        {
            Vector vect_a = new Vector(1,0,-2);
            Vector vect_b = new Vector(1,-1,-4);
            Vector vect_c = vect_a + vect_b;
            Vector vect_d = vect_a * vect_b;
            Console.Write("Vector A is: ");
            vect_a.display();
            Console.Write("Vector B is: ");
            vect_b.display(); 
            Console.Write("Vector Addition (Overloaded +) is: ");
            vect_c.display();
            Console.Write("Cross Product (Overloaded *) is: ");
            vect_d.display();
            Console.Write("Magnitude of Vector A (Overloaded ~) is: ");
            Console.WriteLine($"{~vect_a} unit.");
        }
    }

    public class Vector
    {
        public int x, y, z;
        public Vector(int x=0,int y=0,int z=0)
        {
            this.x = x; 
            this.y = y; 
            this.z = z;
        }

        public static Vector operator +(Vector vector_a, Vector vector_b)
        {
            Vector result = new Vector(0, 0, 0);
            result.x = vector_a.x + vector_b.x;
            result.y = vector_a.y + vector_b.y;
            result.z = vector_a.z + vector_b.z;
            return result;
        }
        public static Vector operator *(Vector vector_a, Vector vector_b)
        {
            Vector result = new Vector(0, 0, 0);
            result.x = (vector_a.y * vector_b.z) - (vector_a.z * vector_b.y);
            result.y = (vector_a.z * vector_b.x) - (vector_a.x * vector_b.z);
            result.z = (vector_a.x * vector_b.y) - (vector_a.y * vector_b.x);
            return result;
        }

        public static double operator ~(Vector vector)
        {
            return Math.Sqrt(vector.x * vector.x + vector.y * vector.y + vector.z * vector.z);
        }
        public void display()
        {
            Console.WriteLine($"[{this.x}, {this.y}, {this.z}]");
        }
    }

}
