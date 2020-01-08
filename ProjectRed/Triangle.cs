using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectRed
{
    public class Triangle
    {
        public const float Pi = 3.14f;
        public float Square(int a, int b)
        {
            float s;
            s = 0.5f * a * b;
            return s;
        }

        public double Hypotenuse(int a, int b)
        {
            double c;
            c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            return c;
        }
    }
}
