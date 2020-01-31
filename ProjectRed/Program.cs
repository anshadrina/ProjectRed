using ProjectRed.Lessons;
using ProjectRed.Lesson23;
using System;

namespace ProjectRed
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("List of names:");
                Names names = new Names();
                names.WriteNames();
                Console.WriteLine("Input your character:");
                char devider = char.Parse(Console.ReadLine());
                names.WriteNames(devider);
            }
        }
        private static Warrior ChooseWarrior()
        {
            Console.WriteLine("Choose your warrior.");
            Console.WriteLine("Input 1 if you want a warrior in the light armor.");
            Console.WriteLine("Input 2 if you want a warrior in the hard armor.");
            int warrior = int.Parse(Console.ReadLine());
            if (warrior == 1)
            {
                return new WarriorLightArmor();
            }
            else if (warrior == 2)
            {
                return new WarriorHardArmor();
            }
            else
            {
                Console.WriteLine("Wrong command. Try again.");
                return ChooseWarrior();
            }
        }

        private static void KillWarrior(Warrior userWarrior)
        {
            
            while (userWarrior.CurrentAmountLives > 0)
            {
                Console.WriteLine("Input amount of damage");
                double damage = double.Parse(Console.ReadLine());
                userWarrior.GetDamage(damage);
                Console.WriteLine("Ammount of lives: " + userWarrior.CurrentAmountLives);
            }
            Console.WriteLine("Your warrior was killed.");
            
        }

        private static void ChangeChanel(TV tv)
        {
            Console.WriteLine("Input + if you want to switch chanel to the next.");
            Console.WriteLine("Input - if you want to switch chanel to the previous.");
            Console.WriteLine("Input number if you want to switch chanel to the next.");
            string command = Console.ReadLine();

            try
            {
                if (command == "+")
                {
                    tv.NextChanel();
                }
                else if (command == "-")
                {
                    tv.PreviousChanel();
                }
                else
                {
                    short channel = short.Parse(command);
                    tv.ChangeChanel(channel);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Current channel: " + tv.CurrentChannel);
        }

        private static void GetMaxLength()
        {
            Console.WriteLine("Input file path:");
            string filePath = Console.ReadLine();
            Files files = new Files();
            try
            {
                Console.WriteLine("The longest line is: " + files.GetMaxLengthLine(filePath));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void WriteArrayToFile()
        {
            Console.WriteLine("Input file path:");
            string filePath = Console.ReadLine();
            string[] array = { "red", "green", "black", "white", "blue" };
            Files files = new Files();
            try
            {
                files.WriteArrayToFile(array, filePath);
                Console.WriteLine("File is successfully updated");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private static void CreateFileWithNumbers()
        {
            Console.WriteLine("Input full path to file:");
            string filePath = Console.ReadLine();
            Files files = new Files();
            try
            {
                files.WriteNumbersToFile(filePath: filePath);
                Console.WriteLine("File was created");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private static void SummArrayElements()
        {
            int[] array = { 5, 15, 85, 45, 12, 41, 7, 54, 68, 12 };
            try
            {
                Console.WriteLine("Input index of element 1:");
                int element1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Input index of element 2:");
                int element2 = int.Parse(Console.ReadLine());
                Exceptions exception = new Exceptions();
                Console.WriteLine("Summ of elements: " + exception.SummArrayElements(array, element1, element2));
            }
            catch (FormatException)
            {
                Console.WriteLine("Inputted value is not a number");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
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
