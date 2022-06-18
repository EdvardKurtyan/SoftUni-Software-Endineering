using System;
using System.Linq;

namespace _02._Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            // a, e, i, o, u
            string input = Console.ReadLine();

            NumberOfVowelsInInupt(input);
        }

        private static void NumberOfVowelsInInupt(string text)
        {
            Console.WriteLine(text.Count(vowles => "ariou".Contains(vowles)));
        }
    }
}
