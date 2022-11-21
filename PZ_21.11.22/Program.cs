using System;
using System.IO;

namespace PZ_21._11._22
{
    class Program
    {

        static void Main(string[] args)
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (var item in drives)
            {
                Console.WriteLine($"Название: {item.Name} \nТип: {item.DriveType}" );
                if (item.IsReady)
                {
                    Console.WriteLine($"Объем диска: {item.TotalSize/1024/1024/1024} Gb \n" + 
                        $"Свободное пространство: {item.TotalFreeSpace/1024/1024/1024} Gb \n" + 
                        $"Метка: {item.VolumeLabel}");
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            string dir = @"D:\";
            if (Directory.Exists(dir))
            {
                string dirName = "work";
                string newDir = $@"D:\{dirName}";
                DirectoryInfo directory = new DirectoryInfo(newDir);
                if (!directory.Exists)
                {
                    directory.Create();
                }

                DirectoryInfo subDir = directory.CreateSubdirectory("temp");

                Console.WriteLine($"Название каталога: {subDir.Name}");
                Console.WriteLine($"Полное название каталога: {subDir.FullName}");
                Console.WriteLine($"Время создания каталога: {subDir.CreationTime}");
                Console.WriteLine($"Корневой каталог: {subDir.Root}");

                Console.WriteLine();
                if (subDir.FullName != @"D:\work\newTemp\")
                {
                    subDir.MoveTo(@"D:\work\newTemp");

                    if (subDir.FullName == @"D:\work\newTemp\")
                    {
                        Console.WriteLine("вложенный каталог переместился успешно!");
                    }
                }

                else
                {
                    Console.WriteLine("вложенный каталог переместился неуспешно!");
                }
               
                Console.WriteLine();
                if (subDir.FullName == @"D:\work\")
                {
                    subDir.Delete(true);
                }
                else
                {
                    Console.WriteLine($"Вложенный каталог {subDir.Name} не может быть удален из-за другого распложения");
                }
            }
            Console.WriteLine();



        }
    }
}
