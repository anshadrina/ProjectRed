using System;

namespace ProjectRed
{
    class Program
    {
        static void Main(string[] args)
        {
             AdditionArray();
            

        }

        private static void CreateArray()
        {
            int a = 1;
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(a + i * 3);
            }
        }

        private static void GetPassword()
        {
            string password;
            do
            {
                Console.WriteLine("Input password:");
                password = Console.ReadLine();
            }
            while (password != "root");
            Console.WriteLine("Password is correct.");
        }

        private static void AdditionArray()
        {
            int[] array1 = { 2, 3, 7, 2, 5, 33, 1, 45, 67, 8 };
            int[] array2 = { 5, 34, 5, 2, 5, 87, 23, 4, 9, 96 };
            int[] array3 = new int[10];
            for (int i = 0; i < array3.Length; i++)
            {
                array3[i] = array1[i] + array2[i];
                Console.WriteLine(array3[i]);
            }
            
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
