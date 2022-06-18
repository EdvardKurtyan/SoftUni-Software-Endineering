﻿using System;
using System.Linq;

namespace _06._Equal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            //V
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int leftSum = 0;
            int rightSum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers.Length == 1)
                {
                    Console.WriteLine(0);
                    return;
                }
                leftSum = 0;
                for (int y = i; y > 0; y--)
                {
                    int curentLeftIndex = y - 1;
                    if (y > 0)
                    {
                        leftSum += numbers[curentLeftIndex];
                    }
                }

                rightSum = 0;
                for (int t = i; t < numbers.Length; t++)
                {
                    int curentRightIndex = t + 1;
                    if (t < numbers.Length - 1)
                    {
                        rightSum += numbers[curentRightIndex];
                    }
                }

                if (rightSum == leftSum)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
            Console.WriteLine("no");
        }
    }
}
