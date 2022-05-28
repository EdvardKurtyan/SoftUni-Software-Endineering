using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            //V
            //             Friday     Saturday    Sunday
            // Students     8.45        9.80       10.46
            // Business     10.90       15.60      16
            // Regular      15          20         22.50

            int people = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();

            double price = 0;
            switch (type)
            {
                case "Students":
                    switch (dayOfWeek)
                    {
                        case "Friday":
                            price = 8.45;
                            break;
                        case "Saturday":
                            price = 9.80;
                            break;
                        case "Sunday":
                            price = 10.46;
                            break;
                    }
                    if (people >= 30)
                    {
                        price *= people;
                        price = price - price * 0.15;
                    }
                    else
                    {
                        price *= people;
                    }
                    break;
                case "Business":
                    switch (dayOfWeek)
                    {
                        case "Friday":
                            price = 10.90;
                            break;
                        case "Saturday":
                            price = 15.60;
                            break;
                        case "Sunday":
                            price = 16;
                            break;
                    }
                    if (people >= 100)
                    {
                        people -= 10;
                        price *= people;
                    }
                    else
                    {
                        price *= people;
                    }
                    break;
                case "Regular":
                    switch (dayOfWeek)
                    {
                        case "Friday":
                            price = 15;
                            break;
                        case "Saturday":
                            price = 20;
                            break;
                        case "Sunday":
                            price = 22.50;
                            break;
                    }
                    if (people >= 10 && people <= 20)
                    {
                        price *= people;
                        price = price - price * 0.05;
                    }
                    else
                    {
                        price *= people;
                    }
                    break;
            }
            Console.WriteLine($"Total price: {price:f2}");
        }
    }
}
