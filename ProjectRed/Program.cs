using System;

namespace ProjectRed
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle straight = new Triangle();
            var s = straight.Square(5, 7);
            Console.WriteLine(s);
            var c = straight.Hypotenuse(5, 7);
            Console.WriteLine(c);

        }
    }
}
