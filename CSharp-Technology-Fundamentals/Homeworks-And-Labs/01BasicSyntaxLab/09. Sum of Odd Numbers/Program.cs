﻿using System;

namespace _09SumOfOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //V
            int num = int.Parse(Console.ReadLine());
            int sum = 0;

            int counter = 0;
            for (int i = 1; counter < num; i++)
            {
                if (i % 2 != 0)
                {
                    sum += i;
                    Console.WriteLine(i);
                    counter++;
                }
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
