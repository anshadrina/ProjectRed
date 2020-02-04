using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectRed.Lessons
{
    public class Circle : Figure
    {
        public double Radius { get; set; }

        public Circle(double x, double y, double radius) : base(x, y)
        {
            Radius = radius;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            Circle circle = obj as Circle;
            if (circle as Circle == null)
            {
                return false;
            }
            return circle.X == X && circle.Y == Y && circle.Radius == Radius; 
        }

        public override int GetHashCode()
        {
            return (int)(this.X + this.Y + this.Radius);
        }
    }
}
