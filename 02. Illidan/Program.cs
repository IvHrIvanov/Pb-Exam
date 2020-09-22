using System;

namespace _02._Illidan
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int powerOnePerson = int.Parse(Console.ReadLine());
            int healthBoss = int.Parse(Console.ReadLine());

            int totalPower = people * powerOnePerson;
           
            if (healthBoss < totalPower)
            {
                int needMore = totalPower-healthBoss;
                Console.WriteLine($"Illidan has been slain! You defeated him with {needMore} points.");

            }
            else
            {
                int healthMore = healthBoss-totalPower;
                Console.WriteLine($"You are not prepared! You need {healthMore} more points.");
            }
        }
    }
}
