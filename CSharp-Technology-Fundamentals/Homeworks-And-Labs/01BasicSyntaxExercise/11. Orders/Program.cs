using System;

namespace _11._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 5;

            for (int i = 0; i < num; i++)
            {
                for (int y = 0; y < i; y++)
                {
                    Console.WriteLine(" ");
                }
            }
        }
    }
}
