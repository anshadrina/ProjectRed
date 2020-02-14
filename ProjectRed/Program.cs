using ProjectRed.Lessons;
using ProjectRed.Lesson23;
using System;
using System.Text.RegularExpressions;
using System.Net;
using System.IO;
using System.Text;

namespace ProjectRed
{
    class Program
    {
        static void Main(string[] args)
        {
            GetResponse();
        }

        private static void GetResponse()
        {
            string uri = "http://mycsharp.ru/";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            request.Headers.Add("User-Agent: lesson34");
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (line.Contains("<h2>"))
                {
                    string header = reader.ReadLine();
                    header = header.Trim();
                    while (header.Contains('<') && header.Contains('>')) 
                    {
                        int indexOpen = header.IndexOf('<');
                        int indexClosed = header.IndexOf('>');

                        header = header.Remove(indexOpen, indexClosed - indexOpen + 1);
                    }
                    Console.WriteLine(header);
                }
            }
        }

        private static void GetAverageCircle()
        {
            CircleStruct[] circles = new CircleStruct[10];
            for (int i = 0; i < circles.Length; i++)
            {
                Console.WriteLine("Input radius for circle " + (i+1));
                CircleStruct circle;
                circle.Radius = double.Parse(Console.ReadLine());
                circles[i] = circle;
            }
            double average = CountAverage(circles);
            Console.WriteLine("Average circle radius is " + average);
            Console.WriteLine("Nearest circle radius is " + FindClosest(circles, average)?.Radius);
            
        }
        private static CircleStruct? FindClosest(CircleStruct[] circles, double target)
        {
            CircleStruct? closestElement = null;
            double distance = double.MaxValue;
            foreach (CircleStruct el in circles)
            {
                double currentDistance = Math.Abs(el.Radius - target);
                if (currentDistance < distance)
                {
                    distance = currentDistance;
                    closestElement = el;
                }
            }
            return closestElement;
        }

        private static double CountAverage(CircleStruct[] circles)
        {
            double summ = 0;
            foreach (CircleStruct el in circles)
            {
                summ += el.Radius;
            }
            return summ / circles.Length;
        }

        private static void GetChildren(string fatherName, int? amountChildren)
        {
            if (amountChildren == null)
            {
                Console.WriteLine("Amount of " + fatherName + " children unknown.");
            }
            else if (amountChildren > 0)
            {
                Console.WriteLine("Amount of " + fatherName + " children: " + amountChildren);
            }
            else
            {
                Console.WriteLine(fatherName + " has no children");
            }
        }
        private static Cat CreateCat()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Input amount of cat's hungry.");
                    int hungry = int.Parse(Console.ReadLine());
                    return new Cat(hungry);
                }
                catch (Exception)
                {
                    Console.WriteLine("You inputted not a number. Try again.");
                }
            }
        }

        private static Food GetFood()
        {
            while (true)
                try
                {
                    Console.WriteLine("Choose food (Fish, Milk, Meat, Mouse, Watter):");
                    return (Food)Enum.Parse(typeof(Food), Console.ReadLine());
                }
            catch (Exception)
                {
                    Console.WriteLine("Wrong value. Try again.");
                }
        }

        private static void FeedCat(Cat cat, Food food)
        {
            switch (food)
            {
                case Food.Fish:
                    cat.Hungry -= 25;
                    break;
                case Food.Milk:
                    cat.Hungry -= 15;
                    break;
                case Food.Meat:
                    cat.Hungry -= 59;
                    break;
                case Food.Mouse:
                    cat.Hungry -= 30;
                    break;
            }

        }


        private static void GetTemperature()
        {
            DateTime[] dateTimes =
            {
                new DateTime(2020, 1, 20, 5, 0, 0), 
                new DateTime(2020, 1, 21, 18, 0, 0), 
                new DateTime(2020, 1, 22, 18, 20, 0), 
                new DateTime(2020, 1, 23, 18, 0, 0), 
                new DateTime(2020, 1, 24, 18, 0, 0) 
            };

            float[] temperature = { 26.3f, 27.1f, 25f, 34.2f, 16f };

            for (int i = 0; i < dateTimes.Length; i++)
            {
                Console.WriteLine("{0:MMM dd ddd t} > {1:##.0} °C", dateTimes[i], temperature[i]);
            }
           
        }
        private static void FilterMat()
        {
            Console.WriteLine("Input text:");
            string text = Console.ReadLine();
            Regex filter = new Regex(@"(fuck|bitch|whore)\S*", RegexOptions.IgnoreCase);
            var matches = filter.Matches(text);
            text = filter.Replace(text, "censored");
            Console.WriteLine(text);
        }
        private static void CheckPassword()
        {
            Console.WriteLine("Input password.");
            string password = Console.ReadLine();
            Regex passwordReg = new Regex(@"^[a-zA-Z]{1}\w{1,9}$");
            Console.WriteLine(passwordReg.IsMatch(password));
        }
        private static double GetX()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Input x:");
                    double x = double.Parse(Console.ReadLine());
                    return x;
                }
                catch (Exception)
                {
                    Console.WriteLine("You inputted not a number. Try again.");
                }
            }
        }
        private static double GetY()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Input y:");
                    double y = double.Parse(Console.ReadLine());
                    return y;
                }
                catch (Exception)
                {
                    Console.WriteLine("You inputted not a number. Try again.");
                }
            }
        }

        private static double GetRadius()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Input radius:");
                    double radius = double.Parse(Console.ReadLine());
                    return radius;
                }
                catch (Exception)
                {
                    Console.WriteLine("You inputted not a number. Try again.");
                }
            }
        }

        private static decimal GetAmountMoney()
        {
            try
            {
                Console.WriteLine("Input amount:");
                decimal amount = decimal.Parse(Console.ReadLine());
                return amount;
            }
            catch (Exception)
            {
                Console.WriteLine("You inputted not a number. Try again.");
                return GetAmountMoney();
            }
        }

        private static string GetCurrency()
        {
            Console.WriteLine("Input currency (RU or USD):");
            string currency = Console.ReadLine();
            if (currency == "RU" || currency == "USD")
            {
                 return currency;
            }
            else
            {
                Console.WriteLine("Wrong currency. Try again.");
                return GetCurrency();
            }
        }

        private static void SummMoney(Money money1, Money money2)
        {
            Money summ = money1 + money2;
            Console.WriteLine("Summ of my money: " + summ.Amount + ", " + summ.Unit);
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
