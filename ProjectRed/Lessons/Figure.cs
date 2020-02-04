using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectRed.Lessons
{
    public class Figure
    {
        public double X { get; set; }
        public double Y { get; set; }


        public Figure()
        {
            X = 0;
            Y = 0;
        }

        public Figure(double x, double y)
        {
            X = x;
            Y = y;
        }

        public void Draw()
        {

        }
    }
}
