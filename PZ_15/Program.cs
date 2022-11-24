using System;
using System.IO;

namespace PZ_15
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fileStream = new FileStream(@"D:\text.txt", FileMode.Append);

            Console.WriteLine("Введите произвольную строку в ваш файл:");
            string str = Console.ReadLine();
            StreamWriter streamwriter = new StreamWriter(fileStream);
            streamwriter.Write(str);
            streamwriter.Close();

            char[] strArr = str.ToCharArray();
            Array.Sort(strArr);
            var str2 = "";
            foreach (var item in strArr)
            {
                str2 += item;
            }

            FileStream fileStream2 = new FileStream(@"D:\text.txt", FileMode.Truncate);
            StreamWriter streamwrite = new StreamWriter(fileStream2);
            streamwrite.Write(str2);
            streamwrite.Close();
            Console.WriteLine($"Содержимое вашего файла:{str2}");
        }
    }
}
