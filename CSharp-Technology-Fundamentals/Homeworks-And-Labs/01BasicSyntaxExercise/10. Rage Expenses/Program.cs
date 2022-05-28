    using System;

    namespace _10._Rage_Expenses
    {
        class Program
        {
            static void Main(string[] args)
            {
                int lostGames = int.Parse(Console.ReadLine());
                double headsetPrice = double.Parse(Console.ReadLine());
                double mousePrice = double.Parse(Console.ReadLine());
                double keyboardPrice = double.Parse(Console.ReadLine());
                double displayPrice = double.Parse(Console.ReadLine());

                double fullPrice = 0;
                int keyboardBreaksCounter = 0;
                for (int i = 1; i < lostGames; i++)
                {
                    // When he breaks his headset.
                    if (i % 2 == 0)
                    {
                        fullPrice += headsetPrice;
                    }
                    // When he break his mouse.
                    if (i % 3 == 0)
                    {
                        fullPrice += mousePrice;
                    }
                    // When he broke his headset and mouse at the same time.
                    if (i % 6 == 0)
                    {
                        keyboardBreaksCounter++;
                        fullPrice += keyboardPrice;

                        // When he break his display.
                        if (keyboardBreaksCounter % 2 == 0)
                        {
                            fullPrice += displayPrice;
                        }
                    }

                }
                //•	As output you must print Petar's total expenses: "Rage expenses: {expenses} lv.".
                Console.WriteLine($"Rage expenses: {fullPrice:f2} lv.");
            }
        }
    }

