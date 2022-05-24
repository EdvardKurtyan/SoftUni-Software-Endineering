using System;

namespace _06._Strong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            //V
            int num = int.Parse(Console.ReadLine());
            int numCopy = num;

            int allSumed = 0;
            int sum = 1;
            while (num > 0)
            {
                int factorial = 1;
                int curentNum = num % 10;
                num /= 10;
                sum = 1;
                for (int i = factorial; i <= curentNum; i++)
                {
                    sum = sum * i;
                }
                allSumed += sum;
                curentNum = num;
            }

            Console.WriteLine(numCopy == allSumed ? "yes" : "no");
        }
    }
}
