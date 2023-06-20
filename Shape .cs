using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceFullTask
{
    public abstract class Shape
    {
        public abstract void GetArea();
        public abstract void GetPerimeter();
    }

    public class Circle : Shape 
    {
        public double r = 4;
        public override void GetArea()
        {
            Console.WriteLine("The Area of Circle = " + 3.14 * r * r);
        }
        public override void GetPerimeter()
        {
            Console.WriteLine("The Perimeter of Circle = " + 2 * 3.14 * r);
        }
    }

    public class Rectangle : Shape
    {
        public double a = 4;
        public double b = 6;
        public override void GetArea()
        {
            Console.WriteLine("The Area of Rectangle = " + a * b);
        }
        public override void GetPerimeter()
        {
            Console.WriteLine("The Perimeter of Rectangle = " + 2 * (a + b));
        }
    }

}
