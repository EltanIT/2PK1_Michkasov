using System;
using System.IO;

namespace PZ_23._11._22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вариант 18");
            FileStream fileStream = new FileStream(@"D:\text.txt",FileMode.Append);

            Console.WriteLine("Введите произвольную строку в ваш файл:");
            string str = Console.ReadLine();
            StreamWriter streamwriter = new StreamWriter(fileStream);
            streamwriter.Write(str);
            streamwriter.Close(); 

            FileStream fileStream2 = new FileStream(@"D:\text.txt", FileMode.OpenOrCreate);
            StreamReader streamReader = new StreamReader(fileStream2);
            
            string str2 = streamReader.ReadToEnd();
            streamReader.Close();
            Console.WriteLine($"Содержимое вашего файла:{str2}");
        }

        
    }
}
