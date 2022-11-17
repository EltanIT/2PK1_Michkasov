using System;

namespace PZ_14_I
{
    class Program
    {
        private static double result = -1.0;

        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1:");
            int a = 0;
            Console.Write("Введите n: ");
            int n = int.Parse(Console.ReadLine());
            ArifmeticAl(n, a);
            Z2();
            Z3();
            Z_na_5();
        }
        static void ArifmeticAl(int n, int a)
        {

            if (a < n)
            {
                a++;
                result += (-0.2);
                ArifmeticAl(n, a);
            }
            else if (a == n)
            {
                Console.WriteLine(result + $"\n");
            }
        }



        
        static void Z2()
        {
            result = 11;
            Console.WriteLine("Задание 2:");
            int a = 0;
            Console.Write("Введите n: ");
            int n = int.Parse(Console.ReadLine());
            ArifmeticGem(n, a);
        }
        static void ArifmeticGem(int n, int a)
        {

            if (a < n)
            {
                a++;
                result += Math.Pow(result, -3);
                ArifmeticGem(n, a);
            }
            else if (a == n)
            {
                Console.WriteLine(result + $"\n");
            }
        }


        static void Z3()
        {
            Console.WriteLine("Задание 3:");
            Console.Write("Введите A(если это не целое число, введите дробную часть через точку): ");
            double A = double.Parse(Console.ReadLine());
            Console.Write("Введите B(если это не целое число, введите дробную часть через точку): ");
            double B = double.Parse(Console.ReadLine());
            if (A < B)
            {
                A--;
                Arifmetic(A, B);
            }
            else if (B < A)
            {
                B--;
                Arifmetic(A, B);
            }
        }
        static void Arifmetic(double A, double B)
        {
            if (A < B)
            {
                A++;
                Console.Write(A + " ");
                Arifmetic(A, B);
            }
            else if (B < A)
            {
                Console.Write(A + " ");
                A--;
                Arifmetic(A, B);
            }
        }

        static void Z_na_5()
        {
            result = 1;
            Console.WriteLine("Задание на 5 №1");
            Console.Write("Введите число для расчета его факториала: ");
            int x = int.Parse(Console.ReadLine());
            ArifmeticaFac(x);
            Console.WriteLine($"Ответ: {result}");
        }

        public static int a = 1;
        static void ArifmeticaFac(int x)
        {
            if (a < x)
            {
                a++;
                result += a;
                ArifmeticaFac(x);
            }
            
        }
    }
}
