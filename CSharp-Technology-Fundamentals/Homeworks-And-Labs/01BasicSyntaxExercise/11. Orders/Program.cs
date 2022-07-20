using System;

namespace _11._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            int orders = int.Parse(Console.ReadLine());

            double sum = 0;
            double currentSum = 0;
            for (int i = 1; i <= orders; i++)
            {
                double capsulePrice = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsulesCount = int.Parse(Console.ReadLine());

                currentSum = (days * capsulesCount) * capsulePrice;
                Console.WriteLine($"The price for the coffee is: ${currentSum:f2}");
                sum += currentSum;
            }
            Console.WriteLine($"Total: ${sum:f2}");
        }
    }
}
