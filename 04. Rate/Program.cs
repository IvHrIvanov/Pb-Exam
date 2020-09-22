using System;

namespace _04._Rate
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyComplicated = 0.027;
            double moneynotComplicated = 0.03;

            string simple = "simple";
            string complex = "complex";

            double moneyAdd = double.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            double moneyOne = moneyAdd;
            double moneyTwo = moneyAdd;

            for (int i = 0; i < month; i++)
            {
                moneyOne+=(moneyAdd * moneynotComplicated); 
                moneyTwo+=(moneyTwo * moneyComplicated);
            }
            Console.WriteLine($"Simple interest rate: {moneyOne:f2} lv.");
            Console.WriteLine($"Complex interest rate: {moneyTwo:f2} lv.");
            
            if (moneyOne>moneyTwo)
            {
                double goodMoney = moneyOne - moneyTwo;
                Console.WriteLine($"Choose a {simple} interest rate. You will win {goodMoney:f2} lv.");
            }
            else
            {
                double goodMoney = moneyTwo-moneyOne;
                Console.WriteLine($"Choose a {complex} interest rate. You will win {goodMoney:f2} lv.");

            }
        }
    }
}
