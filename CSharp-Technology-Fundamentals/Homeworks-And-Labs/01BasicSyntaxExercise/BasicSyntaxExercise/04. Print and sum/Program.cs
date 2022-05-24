using System;

namespace _04._Print_and_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            //V
            int startNum = int.Parse(Console.ReadLine());
            int endingNum = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = startNum; i <= endingNum; i++)
            {
                Console.Write($"{i} ");
                sum += i;
            }
            Console.WriteLine();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
