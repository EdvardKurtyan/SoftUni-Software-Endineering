using System;

namespace _09._Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            //V
            double money = double.Parse(Console.ReadLine());
            double students = double.Parse(Console.ReadLine());

            double lightsabersPrice = double.Parse(Console.ReadLine());
            double robesPrice = double.Parse(Console.ReadLine());
            double beltsPrice = double.Parse(Console.ReadLine());

            // The price for lightsabers
            double tenPersentsMoreLightsabers = Math.Ceiling(students + students * 0.1);
            lightsabersPrice = tenPersentsMoreLightsabers * lightsabersPrice;

            //The price for the belts
            double beltsPriceCopy = beltsPrice;
            beltsPrice *= students;
            for (int i = 1; i <= students; i++)
            {
                if (i % 6 == 0)
                {
                    beltsPrice -= beltsPriceCopy;
                }
            }

            // The price for the robes
            robesPrice *= students;

            // The whole price lightsabers + belts + robes
            double wholePrice = lightsabersPrice + beltsPrice + robesPrice;

            //• If the calculated price of the equipment is less or equal to the money John has:
            //o   "The money is enough - it would cost {the cost of the equipment}lv."
            //•	If the calculated price of the equipment is more than the money John has:
            //o    " John will need {neededMoney}lv more."
            if (wholePrice <= money)
            {
                Console.WriteLine($"The money is enough - it would cost {wholePrice:f2}lv.");
            }
            else
            {
                wholePrice -= money;
                Console.WriteLine($"John will need {wholePrice:f2}lv more.");
            }

            //•	All prices must be rounded to two digits after the decimal point.
        }
    }
}
