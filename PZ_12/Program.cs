using System;

namespace PZ_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите колличество раз выполнения программы(3)");
            int a = int.Parse(Console.ReadLine());
            int bol = 1;
        restart:
            Console.WriteLine("Введите значения координат для определения прямоугольника: x1,y1,x2,y2");
            double x1 = int.Parse(Console.ReadLine());
            double y1 = int.Parse(Console.ReadLine());
            double x2 = int.Parse(Console.ReadLine());
            double y2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"x1={x1},  y1={y1},  x2={x2},  y2={y2}");

            RectPS(x1, y1, x2, y2);

            if ((bol++) >= a) Console.WriteLine("На этом все");
            else goto restart;

        }
        static void RectPS(double x1, double y1, double x2, double y2)
        {
            double P = (Math.Abs((x1 - x2)) * 2) + (Math.Abs(y1 - y2) * 2);
            double S = (Math.Abs(x1 - x2)) + (Math.Abs(y1 - y2));
            Console.WriteLine($"P = {P}\t S = {S}");
        }
    }
}
