using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectRed
{
    public class Triangle
    {
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
