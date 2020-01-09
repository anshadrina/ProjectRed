using System;

namespace ProjectRed
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input parameter a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Input parameter b");
            int b = int.Parse(Console.ReadLine());


            Triangle straight = new Triangle();

            try
            {
                var s = straight.Square(a, b);
                Console.WriteLine("Square: " + s);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Error");
            }

            try
            {
                var c = straight.Hypotenuse(a, b);
                Console.WriteLine("Hypotenuse: " + c);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Error");
            }
            

        }
    }
}
