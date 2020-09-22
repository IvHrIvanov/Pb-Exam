using System;

namespace _05._Everest
{
    class Program
    {
        static void Main(string[] args)
        {

            int height = 5364;
            int everestHeigt = 8848;
            int day = 1;

            string input = Console.ReadLine();
            string metters;
            
            while(input !="END" && day<=5)
            {
                
                metters = Console.ReadLine();
                
                if (metters=="END")
                {
                    break;
                }
                if(input=="Yes")
                {
                    day++;
                    
                }
                else if(input == "No")
                {
                    day--;
                }
                
                height += int.Parse(metters);
                if(height>=everestHeigt)
                {
                    break;
                }
                if (day >= 5)
                {
                    break;
                }
                input = Console.ReadLine();
            }
            if(height>=everestHeigt)
            {
                Console.WriteLine($"Goal reached for {day} days!");
            }
            else
            {
                Console.WriteLine($"Failed!");
                Console.WriteLine(height);
            }

        }

    }
}
