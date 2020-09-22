using System;

namespace _05._Easter_Bake
{
    class Program
    {
        static void Main(string[] args)
        {
            //gram

            double sugar = 950;
            double flour = 750;

            //gram

            double sugarAdd = 0;
            double flourAdd = 0;

            int bread = int.Parse(Console.ReadLine());

            int maxSugar = 0;
            int maxFlour = 0;
            int addNumber = 0;

            while (addNumber != bread)
            {
                int sugarUsed = int.Parse(Console.ReadLine());
                int flourUsed = int.Parse(Console.ReadLine());

                addNumber++;

                sugarAdd += sugarUsed;
                flourAdd += flourUsed;

                if (maxSugar < sugarUsed)
                {
                    maxSugar = sugarUsed;
                }
                if (maxFlour < flourUsed)
                {
                    maxFlour = flourUsed;
                }
            }

            double totalSugar = Math.Ceiling(sugarAdd / sugar);
            double totalFlour = Math.Ceiling(flourAdd / flour);

            Console.WriteLine($"Sugar: {totalSugar}");
            Console.WriteLine($"Flour: {totalFlour}");
            Console.WriteLine($"Max used flour is {maxFlour} grams, max used sugar is {maxSugar} grams.");
        }
    }
}
