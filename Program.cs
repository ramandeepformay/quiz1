using System;

namespace quiz1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the age to get the best price for you :)");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age <= 5)
            {
                Console.WriteLine("Free");
            }
            else if (age > 5 && age < 14)
            {
                Console.WriteLine("Price is 7.99");
            }
            else if (age >= 14 && age < 65)
            {
                Console.WriteLine("Price is 11.99");
            }
            else
            {
                Console.WriteLine("9.99");
            }

        }
    }
}
