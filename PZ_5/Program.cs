using System;

namespace PZ_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вариант 18");

            Console.WriteLine("\nЗадание 1");
            for (int r = 10; r <= 70; r += 5)
            {
                Console.WriteLine(r);
            }


            Console.WriteLine("\nЗадание 2");
            char Al = 'Г';
            for (char e = Al; e <= 'К'; e++)
            {
                Console.WriteLine(e);
            }


            Console.WriteLine("\nЗадание 3");
            for (int t = 0; t < 9; t++)
            {

                for (int y = 0; y < 4; y++)
                {
                    Console.Write('#');
                }
                Console.WriteLine();
            }


            Console.WriteLine("\nЗадание 4");
            for (int u = 0; u <= 100; u++)
            {
                if (u % 4 == 0)
                {
                    Console.Write($"{u} ");
                }
            }
            Console.WriteLine();


            Console.WriteLine("\nЗадание 5");
            for (int i = 5, j=64; j - i != 23; ++i, --j)
            {
                Console.WriteLine($"i = {i}");
                Console.WriteLine($" j = {j}");
            }
        }
    }
}
