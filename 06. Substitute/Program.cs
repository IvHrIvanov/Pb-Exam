using System;

namespace _06._Substitute
{
    class Program
    {
        static void Main(string[] args)
        {
            int K = int.Parse(Console.ReadLine());
            int L = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());

            int com = 0;
            for (int a = K; a <= 8; a++)
            {
                for (int b = 9; b >= L; b--)
                {
                    for (int c = M; c <= 8; c++)
                    {
                        for (int d = 9; d >= N; d--)
                        {
                            if (a % 2 == 0 && b % 2 == 1 && c % 2 == 0 && d % 2 == 1 && a == c && b == d)
                            {
                                Console.WriteLine("Cannot cange the same player.");
                            }
                            else if (a % 2 == 0 && b % 2 == 1 && c % 2 == 0 && d % 2 == 1)
                            {
                                com++;
                                Console.WriteLine($"{a}{b}-{c}{d}");

                            }
                            if(com == 6)
                            {
                                Environment.Exit(0);
                            }
                        }
                    }
                }

            }
        }

    }
}

