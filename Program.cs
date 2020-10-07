using System;

namespace quiz1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime currentDate = DateTime.Now;
            double price;

            Console.WriteLine("Enter the age to get the best price for you :)");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Do you have a University Card? If yes enter yes or y");
            string univCard = Console.ReadLine();

            if (age < 0 && age > 130)
            {
                System.Console.WriteLine("Invalid I/P. Enter the correct age");
                return;
            }

            if (age <= 5)
            {
                price = 0.0;
            }
            else if (age > 5 && age < 14)
            {
                price = 7.99;
            }
            else if (age >= 14 && age < 65)
            {
                price = 11.99;

            }
            else
            {
                price = 9.99;
            }

            if (currentDate.DayOfWeek == DayOfWeek.Tuesday)
            {
                price /= 2;
                price = Math.Round(price, 2);
            }

            if (univCard == "y" || univCard == "yes")
            {
                price /= 1;
            }

            System.Console.WriteLine($"Price of th ticket is {price}");
        }


    }
}

