﻿using System;

namespace _05._Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNuber = int.Parse(Console.ReadLine());
            int secondNuber = int.Parse(Console.ReadLine());
            int thirdNuber = int.Parse(Console.ReadLine());

            int add = SummedFirstAndSecondInteger(firstNuber, secondNuber);
            int result = Subtraction(add , thirdNuber);
            Console.WriteLine(result);
        }

        private static int SummedFirstAndSecondInteger(int firstNuber, int secondNuber) => firstNuber + secondNuber;
        private static int Subtraction(int add, int thirdNuber) => add - thirdNuber;
    }
}
