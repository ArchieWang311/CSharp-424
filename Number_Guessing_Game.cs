using System;

namespace HelloWorldApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            // int x = rnd.Next(0, 100);
            int x = int.Parse(Console.ReadLine());
            int min_num = 0, max_num = 99;
            int guess;
            while (true)
            {
                Console.WriteLine("({0}, {1})", min_num, max_num);
                guess = int.Parse(Console.ReadLine());
                if (guess < min_num || guess > max_num)
                {
                    Console.WriteLine("Out of range, try again.");
                    continue;
                }
                if (guess == x)
                {
                    Console.WriteLine("Bingo!\n");
                    break;
                }
                else if (guess < x)
                {
                    min_num = guess + 1;
                }
                else if (guess > x)
                {
                    max_num = guess - 1;
                }

                if (min_num == max_num)
                {
                    Console.WriteLine("GG.");
                    break;
                }
            }
        }
    }
}