using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectRed.Lessons
{
    public class Triangle : Figure
    {
        public Triangle() : base() { }
        public Triangle(double x, double y) : base(x, y) { }

        public double Square(int a, int b)
        {
            if (a > 0 && b > 0)
            {
                double s;
                s = 0.5f * a * b;
                return s;
            }
            else
            {
                throw new ArgumentException("Arguments are invalid");
            }
        }

        public double Hypotenuse(int a, int b)
        {
            if (a > 0 && b >0)
            {
                double c;
                c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
                return c;
            }
           else
            {
                throw new ArgumentException("Arguments are wrong");
            }
        }
    }
}
