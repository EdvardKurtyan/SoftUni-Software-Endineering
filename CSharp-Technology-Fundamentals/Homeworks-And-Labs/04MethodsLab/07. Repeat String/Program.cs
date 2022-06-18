﻿using System;
using System.Linq;
using System.Text;

namespace _07._Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int repeats = int.Parse(Console.ReadLine());

            Console.WriteLine(RepeatingString(input, repeats));

        }

        static string RepeatingString(string input, int repeats)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < repeats; i++)
            {
                result.Append(input);
            }

            return result.ToString();
        }
    }
}
