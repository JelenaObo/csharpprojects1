using System;
using System.Linq;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Testa vards";
            PrintHelloWorld();
            PrintName("Gusts");
            PrintName("Peteris");
            PrintName(name);

           var fullName = PrintFullName("Gusts", "Surmane");
           Console.WriteLine(fullName);

           Console.WriteLine(PrintFullName("Gusts", "Surname"));

           PrintName(PrintFullName("Andris", "Berzs"));

           var newArray = GetPrefilledArray(3, 1);
           var newArray1 = GetPrefilledArray(10, 5);

           PrintArray(newArray);
           PrintArray(newArray1);
           PrintArray(new string[]{"Gusts", "Peteris"});

           var premium = GetPremium(2018, 33, 10, 1);
           var premium2 = GetPremium(2018, 33);
           var premium3 = GetPremium(2018, 44, 10, 0, 3);
           var premium4 = GetPremium(2018, 44, 10, 0, 3,0,1,6);
           var premium5 = GetPremium(2018, 44, 10, 0, 3, y:6, x:10);

           int number;
           var result = ParseInt("e", out number);

           GetSum(1);
           GetSum(1, 4, 6, 7);

        }

        static void PrintHelloWorld()
        {
            Console.WriteLine("Hello World");
        }

        static void PrintName(string name)
        {
            Console.WriteLine($"Your name is {name}");
        }

        static string PrintFullName(string name, string surname)
        {
            return $"{name} {surname}";
        }

        static int[] GetNewArray(int size)
        {
            return new int[size];
        }

        static int[] GetPrefilledArray(int size, int defaultValue)
        {
            int[] data = new int[size];
            for (int i = 0; i <data.Length; i++)
            {
                data[i] = defaultValue;
            }

            return data;
        }


        static void PrintArray(int[] numbers)
        {
            var stringArray = numbers.Select(n=>n.ToString()).ToArray();
            PrintArray(stringArray);
        }

        static void PrintArray(string[] names)
        {
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }

        static double GetPremium(int year, int driverAge, int exp, int penalties)
        {
            var premium = year * driverAge / exp * penalties;
            return premium;
        }

        static double GetPremium(int year, int driverAge)
        {
            return GetPremium(year, driverAge, 1, 0);
        }

        static double GetPremium(int year, int driverAge, int exp, int penalties, int colorCode, double PayedPremiums = 0, int x = 1, int y = 2)
        {
            return 0;
        }

        static bool ParseInt(string value, out int number)
        {
            number = 0;
            try
            {
                number = int.Parse(value);
            }
            catch
            {
                return false;
            }


            return true;
        }

        static int GetSum(params int[] numbers)
        {
            var sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }

            return sum;
        }

    }
}
