﻿using System;
using System.Linq;

namespace _04._Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            //V
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rotations = int.Parse(Console.ReadLine());

            int curentArr = 0;
            for (int i = 0; i < rotations; i++)
            {
                curentArr = input[0];
                for (int t = 0; t < input.Length - 1; t++)
                {
                    input[t] = input[t + 1];
                }
                input[input.Length - 1] = curentArr;
            }
            // Console.Write($"{input}");
            Console.WriteLine(String.Join(" ", input));
        }
    }
}
