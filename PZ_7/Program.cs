using System;

namespace PZ_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int valueSum = 0;
            Random n = new Random();
            Random value = new Random();
            int[] array = new int[n.Next(1, 10)];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = value.Next(-10, 10);
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        valueSum += Math.Abs(array[j]);

                    }
                    break;
                }

            }
            Console.Write(valueSum);
        }
    }
}
