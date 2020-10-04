using System;

namespace quiz1
{
    class Program
    {
        static void Main(string[] args)
        {

            TimeZone localZone = TimeZone.CurrentTimeZone;
            DateTime currentDate = DateTime.Now;
            string days = currentDate.DayOfWeek.ToString();


            Console.WriteLine("Enter the age to get the best price for you :)");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Do you have a University Card? If yes enter yes or y");
            string univCard = Console.ReadLine();

            if (age <= 5)
            {
                Console.WriteLine("Free Ticket");
            }
            else if (age > 5 && age < 14)
            {
                if (days == "Tuesday")
                {
                    Console.WriteLine("Price of the ticket is 3.98");
                }
                else if (univCard == "yes" || univCard == "y")
                {
                    Console.WriteLine("Price of the ticket is 6.99");
                }
                else
                {
                    Console.WriteLine("Price of the ticket is 7.99");
                }
            }
            else if (age >= 14 && age < 65)
            {
                if (days == "Tuesday")
                {
                    Console.WriteLine("Price of the ticket is 5.98");
                }
                else if (univCard == "yes" || univCard == "y")
                {
                    Console.WriteLine("Price of the ticket is 10.99");
                }
                else
                {

                    Console.WriteLine("Price of the ticket is 11.99");
                }

            }
            else
            {
                if (days == "Tuesday")
                {
                    Console.WriteLine("Price of the ticket is 4.98");
                }
                else if (univCard == "yes" || univCard == "y")
                {
                    Console.WriteLine("Price of the ticket is 8.99");
                }
                else
                {
                    Console.WriteLine(" Price of the ticket is 9.99");
                }
            }
        }


    }
}

