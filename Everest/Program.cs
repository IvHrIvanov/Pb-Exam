using System;
using System.ComponentModel;

namespace Everest
{
    class Program
    {
        static void Main(string[] args)
        {
            int everest = 8848;
            int start = 5364;
            int days = 1;
            int endDays = 5;

            string input = Console.ReadLine();

            while (input != "END")
            {
                
                if (input == "Yes")
                {
                    days++;
                }               
                
                int addMetters = int.Parse(Console.ReadLine());

                if (days > endDays)
                {
                    break;
                }

                start += addMetters;

                if (everest <= start)
                {
                    break;
                }

                input = Console.ReadLine();
                
                if (input == "No")
                {
                    continue;
                }
               
            }
            if (everest <= start)
            {
                Console.WriteLine($"Goal reached for {days} days!");
            }
            else
            {
                Console.WriteLine($"Failed!");
                Console.WriteLine(start);
            }
        }
    }
}
