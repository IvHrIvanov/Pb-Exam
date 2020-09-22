using System;
using System.Threading;

namespace _03._Aquapark
{
    class Program
    {
        static void Main(string[] args)
        {
            double hoursForDayMarchToMay = 10.50;
            double hoursForNightMarchToMay = 8.40;

            double hoursForDayJuneToAugust = 12.60;
            double hoursForNightJuneToAugust = 10.20;

            string mounth = Console.ReadLine();
            int hoursIn = int.Parse(Console.ReadLine());
            int peopleInGroup = int.Parse(Console.ReadLine());
            string timeOfDay = Console.ReadLine();

            double addHours = 0;

            if (mounth == "march" || mounth == "april" || mounth == "may")
            {
                switch (timeOfDay)
                {
                    case "day":
                        addHours += hoursForDayMarchToMay;
                        break;
                    case "night":
                        addHours += hoursForNightMarchToMay;
                        break;
                }
            }
            else if (mounth == "june" || mounth == "july" || mounth == "august")
            {
                switch (timeOfDay)
                {
                    case "day":
                        addHours += hoursForDayJuneToAugust;
                        break;
                    case "night":
                        addHours += hoursForNightJuneToAugust;
                        break;
                }
            }
            if (peopleInGroup>=4)
            {
                addHours -= addHours * 0.10;
            }
            if (hoursIn >= 5)
            {
                addHours -= addHours * 0.5;
            }
            double totalSum = (addHours * hoursIn) * peopleInGroup;
            Console.WriteLine($"Price per person for one hour: {addHours:f2}");
            Console.WriteLine($"Total cost of the visit: {totalSum:f2}");
        }
    }
}