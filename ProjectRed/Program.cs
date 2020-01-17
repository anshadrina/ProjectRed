using System;

namespace ProjectRed
{
    class Program
    {
        static void Main(string[] args)
        {
            NormolizeLogins();           

        }
        private static void NormolizeLogins()
        {
            Console.WriteLine("Input logins:");
            string logins = Console.ReadLine();
            StringFunc stringFunc = new StringFunc();
            foreach (string login in stringFunc.NormalizeLogins(logins))
            {
                Console.WriteLine(login);
            }
            
        }
        private static void GetSubstring()
        {
            string text = "Сегодня мы с вами рассмотрели, как работать со строками в Си-шарп. Были описаны основные операторы и методы, которые используются для работы со строками";
            
            Console.WriteLine(text.Substring(text.IndexOf("Были"), text.LastIndexOf("методы") - text.IndexOf("Были") + 6));
        }
        private static void GetElement()
        {
            Console.WriteLine("Input element number:");
            int element = int.Parse(Console.ReadLine());
            Functions functions = new Functions();
            Console.WriteLine("Your number is: " + functions.GetElement(element));
        }

        private static void ShowMeth()
        {
            Functions functions = new Functions();
            Console.WriteLine("Input number for comparation:");
            int compareTo = int.Parse(Console.ReadLine());
            int[] array = { 2, 15, 6, 7, 5, 6, 3, 54, 1, -8, 7, 0 };
            array = functions.ChangeElements(compareTo, array);
            foreach (int el in array)
            {
                Console.WriteLine(el);
            }

        }

        private static void GetMin()
        {
            Console.WriteLine("Input number 1:");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Input number 2:");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Input number 3:");
            float c = float.Parse(Console.ReadLine());

            Functions functions = new Functions();
            try
            {
                Console.WriteLine("Minimum number is: " + functions.GetMin(a, b, c));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        private static void Foreach()
        {
            int[] array = { 4, 7, 13, 20, 33, 23, 54 };
            foreach (int el in array)
            {
                if (el > 20 && el < 50) 
                {
                    Console.WriteLine(el);
                }
            }
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
