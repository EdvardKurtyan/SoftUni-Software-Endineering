using System;

namespace _04BackIn30Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            //V
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            minutes += 30;

            if (minutes > 59)
            {
                minutes -= 60;
                hours++;
            }
            if (hours >= 23)
            {
                hours -= 24;
            }

            Console.WriteLine($"{hours}:{minutes:D2}");
        }
    }
}
