﻿using System;
using System.IO;
using System.Text.RegularExpressions;


namespace PZ_19
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();
        }
        static void Task1() // 1-ая задача
        {
            string text = "1 RU161109-472905 PACK19697671 1 Ольга Каверзина +7 (918) 335-43-52 Наличные Плюс 0 09:00 - 13:00 Краснодар, красина, Дом 3/3, Кв. 762 RU161110 - 466130 PACK19651968 1 Софья назаретян +7(918) 398 - 07 - 81 Наличные Плюс 0 09:00 - 13:00 Краснодар, Базовская, Дом д.613 RU161111 - 260536 PACK19698066 3 Виктор Кипуров +7(918) 441 - 97 - 56 Наличные Плюс 0 09:00 - 13:00 Краснодар, Речная,Чехова , Дом 4, Кв. 524 RU161111 - 522664 PACK19697905 2 Ирина Концевик +7(918) 045 - 77 - 00 Наличные Плюс 0 09:00 - 13:00 Краснодар, ул им Братьев Дроздовых, Дом 41, Кв. 195 RU161111 - 252357 PACK19697840 1 Ирина Концевик +7(918) 045 - 77 - 00 Наличные Плюс 0 09:00 - 13:00 Краснодар, ул им Братьев Дроздовых, Дом 41, Кв. 196 RU161104 - 298585 PACK19514804 3 Роман + 7(938) 435 - 93 - 29 Наличные Плюс 0 09:00 - 13:00 Краснодар, фурманова, Дом 62 9.11";

            Regex regex = new Regex(@"[А-Яа-я ]+(?= \+)");

            int matchesLength = regex.Matches(text).Count;

            string[] array = new string[matchesLength];

            for (int i = 0; i < regex.Matches(text).Count; i++)
            {
                array[i] = regex.Matches(text)[i].Value;
                Console.WriteLine(array[i].Trim());
            }
        }
        static void Task2() // 2-ая задача
        {
            string text = @"D://123.txt"; // задание (а)

            Regex regex = new Regex(@"^[\d\.]+"); // определяем маску

            Regex regex1 = new Regex(@"(?<=\[)[\d\/\w:\+ ]+"); //задание(б)

            string[] text2 = File.ReadAllLines(text); // массив строк

            foreach (var item in text2) // бежим по строкам
            {
                foreach (var line in regex.Matches(item)) // ищем соответствия по маске
                {
                    Console.WriteLine(line); // вывод соответствий
                }
                foreach (var lines in regex1.Matches(item))// ищем соответствия по маске для задания б)
                {
                    Console.WriteLine(lines); // вывод соответствий для задания б)
                }
            }
        }
    }
}
