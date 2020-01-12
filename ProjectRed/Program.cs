using System;

namespace ProjectRed
{
    class Program
    {
        static void Main(string[] args)
        {
            DigitCheck();
            

        }

        private static void MatchResults()
        {
            Console.WriteLine("Input owner goals:");
            int ownerGoals = int.Parse(Console.ReadLine());
            Console.WriteLine("Input guest goals:");
            int guestGoals = int.Parse(Console.ReadLine());
            Match match = new Match();
            try
            {
                Console.WriteLine(match.GetResult(ownerGoals, guestGoals));
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Amount of goals could not be negative.");
            }
        }

        private static void DigitCheck()
        {
            Console.WriteLine("Input digit:");
            int digit = int.Parse(Console.ReadLine());
            if (digit % 3 == 0 && digit % 7 == 0)
            {
                Console.WriteLine("Number is multiple of 3 and 7.");
            }
            else
            {
                Console.WriteLine("Number is not multiple of 3 and 7.");
            }
        }

        private static void Triangle()
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
