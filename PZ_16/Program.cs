using System;
using System.IO;

namespace PZ_16
{
    class Program
    {
        static string str;
        static string fileName;
        static int[,] arr;
        static string t = "  ";
        static bool yes = true;

        static void Main(string[] args)
        {
            Console.WriteLine("Вариант 18\n");
            Console.Write("Введите название файла: ");
            fileName = Console.ReadLine();
            
            arr = new int[5, 8];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    int result = i * j;
                    arr[i, j] = result;
                    str = result.ToString();

                    if (j == arr.GetLength(1)-1)
                    {
                        yes = false;
                        FileWrite(str);
                    }
                    else FileWrite(str);

                }
            }
        }
        static void FileWrite(string str)
        {
            FileStream fileStream = new FileStream(@$"D:\{fileName}.txt", FileMode.Append);
            StreamWriter streamwriter = new StreamWriter(fileStream);

            if (yes == false)
            {
                streamwriter.WriteLine(str);
            }
            else
                streamwriter.Write(str + t);
            yes = true;

            streamwriter.Close();
        }
    }
}
