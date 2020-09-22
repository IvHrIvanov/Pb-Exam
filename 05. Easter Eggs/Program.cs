using System;

namespace _05._Easter_Eggs
{
    class Program
    {
        static void Main(string[] args)
        {
            int eggs = int.Parse(Console.ReadLine());

            int redEgg = 0;
            int orangeEgg = 0;
            int blueEgg = 0;
            int greenEgg = 0;

            string color1 = "green";
            string color2 = "red";
            string color3 = "orange";
            string color4 = "blue";

            for (int i = 0; i < eggs; i++)
            {
                string input = Console.ReadLine();
                switch (input)
                {
                    case "red":
                        redEgg++;
                        break;
                    case "orange":
                        orangeEgg++;
                        break;
                    case "blue":
                        blueEgg++;
                        break;
                    case "green":
                        greenEgg++;
                        break;
                }

            }

            Console.WriteLine($"Red eggs: {redEgg}");
            Console.WriteLine($"Orange eggs: {orangeEgg}");
            Console.WriteLine($"Blue eggs: {blueEgg}");
            Console.WriteLine($"Green eggs: {greenEgg}");
            if (redEgg > greenEgg && redEgg > blueEgg && redEgg > orangeEgg)
            {
                Console.WriteLine($"Max eggs: {redEgg} -> {color2}");
            }
           else  if (greenEgg > redEgg && greenEgg > orangeEgg && greenEgg > blueEgg)
            {
                Console.WriteLine($"Max eggs: {greenEgg} -> {color1}");
            }
           else  if (blueEgg > redEgg && blueEgg > greenEgg && blueEgg > orangeEgg)
            {
                Console.WriteLine($"Max eggs: {blueEgg} -> {color4}");

            }
             else if (orangeEgg > redEgg && orangeEgg > blueEgg && orangeEgg > greenEgg)
            {
                Console.WriteLine($"Max eggs: {orangeEgg} -> {color3}");

            }
        }
    }
}
