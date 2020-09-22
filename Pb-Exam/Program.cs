using System;

namespace Pb_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            double dolar = 1.57;
            double processor = double.Parse(Console.ReadLine());
            double videoCard = double.Parse(Console.ReadLine());
            double ramMemmory = double.Parse(Console.ReadLine());
            double ramBoard = double.Parse(Console.ReadLine());
            double discount = double.Parse(Console.ReadLine());
            
            double convertProcesor = processor * dolar;
            double convertVideoCard = videoCard * dolar;
            double convertRamMemmory = ramMemmory * dolar;
            double convertRamBoard = ramBoard * convertRamMemmory;

            double percentDiscountProcessor = convertProcesor - (convertProcesor * discount);
            double percentDiscountVideo = convertVideoCard - (convertVideoCard * discount);

            double totalSum = percentDiscountProcessor + percentDiscountVideo +convertRamBoard;
            Console.WriteLine($"Money needed - {totalSum:f2} leva.");
        }
    }
}
