using System;

namespace _08._Town_Info
{
    class Program
    {
        static void Main(string[] args)
        {
            //V
            string townname = Console.ReadLine();
            long population = long.Parse(Console.ReadLine());
            int area = int.Parse(Console.ReadLine());

            Console.WriteLine($"Town {townname} has population of " +
                $"{population} and area {area} square km.");
        }
    }
}
