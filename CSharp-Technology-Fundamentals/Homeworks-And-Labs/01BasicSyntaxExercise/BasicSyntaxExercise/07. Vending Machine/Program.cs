﻿using System;

namespace _07._Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            // "Nuts" - 2.0
            // "Water" - 0.7
            // "Crisps" - 1.5
            // "Soda" - 0.8
            // "Coke" - 1.0

            string comand = Console.ReadLine();
            double sum = 0;

            while (comand != "Start")
            {
                double inputMoney = double.Parse(comand);
                if (inputMoney == 0.1 || inputMoney == 0.2 || inputMoney == 0.5 || inputMoney == 1.00 || inputMoney == 2.00)
                {
                    sum += inputMoney;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {inputMoney}");
                    inputMoney = double.Parse(Console.ReadLine());
                }
                comand = Console.ReadLine();
            }
            double price = 0;
            comand = Console.ReadLine();
            while (comand != "End")
            {
                switch (comand)
                {
                    case "Nuts":
                        price = 2;
                        break;
                    case "Water":
                        price = 0.7;
                        break;
                    case "Crisps":
                        price = 1.5;
                        break;
                    case "Soda":
                        price = 0.8;
                        break;
                    case "Coke":
                        price = 1;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
