using System;

namespace PZ_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            Random random = new Random() ;
            int[,] array1 = new int[5,5];
            for (int i = 0; i < array1.GetLength(0); i++)
            {
                for (int j = 0; j < array1.GetLength(1); j++)
                {
                    array1[i, j] = random.Next(-50, 50);
                    Console.Write(array1[i,j] + " ");
                }

                Console.WriteLine();

            }//Заполнение массива

            Console.WriteLine();
            for (int i = 0; i < array1.GetLength(0); i++)
            {
                for (int j = 0; j < i; j++)
                {

                    Console.Write(array1[i,j] + " ");
                    if (array1[i,j] < 0)
                    {
                        result++;
                    }
                }
                Console.WriteLine();
            }//вырезание диагонали и всего, что было сверху ее
            Console.WriteLine($"Кол-во отрицательных чисел = {result}");

        }
    }
}
