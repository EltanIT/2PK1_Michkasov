using System;

namespace PZ_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вариант 18");
            double x, y, h;
            x = 1;
            h = 0.2;
            while (1 <= x && x <= 4)
            {
                y = x + 3 * Math.Pow(2, x) - 2.5 * Math.Pow(3, x) + 0.75 * Math.Pow(3, x);
                Console.WriteLine($"y = {y}");
                x += h;
            }
        }
    }
}
