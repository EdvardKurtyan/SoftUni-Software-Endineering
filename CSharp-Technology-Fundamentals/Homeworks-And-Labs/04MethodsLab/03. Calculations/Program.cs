﻿using System;

namespace _03._Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            switch (command)
            {
                case "add":
                    Adding(firstNumber, secondNumber);
                    break;
                case "multiply":
                    Multiplying(firstNumber, secondNumber);
                    break;
                case "subtract":
                    Subtracting(firstNumber, secondNumber);
                    break;
                case "divide":
                    Divide(firstNumber, secondNumber);
                    break;
            }
        }


        private static void Adding(int num1, int num2)
        {
            Console.WriteLine(num1 + num2);
        }
        private static void Multiplying(int num1, int num2)
        {
            Console.WriteLine(num1 * num2);
        }
        private static void Subtracting(int num1, int num2)
        {
            Console.WriteLine(num1 - num2);
        }
        private static void Divide(int num1, int num2)
        {
            Console.WriteLine(num1 / num2);
        }
    }
}
