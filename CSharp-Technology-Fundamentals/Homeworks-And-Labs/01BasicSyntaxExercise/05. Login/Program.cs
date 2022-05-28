using System;

namespace _05._Login
{
    class Program
    {
        static void Main(string[] args)
        {
            //V
            string username = Console.ReadLine();
            int usernameLength = username.Length - 1;
            string realPassword = "";

            for (int i = usernameLength; i >= 0; i--)
            {
                realPassword += username[i];
            }

            string password = Console.ReadLine();

            int incorrectPosswordCounter = 0;
            while (password != realPassword)
            {
                incorrectPosswordCounter++;
                Console.WriteLine("Incorrect password. Try again.");
                password = Console.ReadLine();
                if (incorrectPosswordCounter >= 3)
                {
                    Console.WriteLine($"User {username} blocked!");
                    return;
                }
            }
            if (password == realPassword)
            {
                Console.WriteLine($"User {username} logged in.");
            }
        }
    }
}
