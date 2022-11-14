using System;

namespace PZ_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение n = ");
            int n = int.Parse(Console.ReadLine());
            int[] result = TransArr(n);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
        static int[] TransArr(int n)
        {
            int[] arr = new int[n];

            int g = n;
            for (int i = 0; i < n; i++)
            {
                arr[i] = 10 * (int)Math.Pow(2, g - 1);
                g++;
            }
            return arr;
        }
    }
}
