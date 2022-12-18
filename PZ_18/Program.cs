using System;

namespace PZ_18
{
    class Program
    {
        enum Marks
        {
            Очень_плохо,
            неудовлетворительно,
            удовлетворительно,
            хорошо,
            отлично
        }
        enum Seasons
        {
            Зима,
            Весна,
            Лето,
            Осень
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Вариант 18\n");

            Console.Write("Введите оценку: ");
            string mark = Console.ReadLine();
            switch (mark)
            {
                case "1":
                    Console.WriteLine(Marks.Очень_плохо);
                    break;
                case "2":
                    Console.WriteLine(Marks.неудовлетворительно);
                    break;
                case "3":
                    Console.WriteLine(Marks.удовлетворительно);
                    break;
                case "4":
                    Console.WriteLine(Marks.хорошо);
                    break;
                case "5":
                    Console.WriteLine(Marks.отлично);
                    break;
                default:
                    break;
            }
            Console.WriteLine();
            Console.Write("Введите время года: ");
            Console.WriteLine();
            string season = Console.ReadLine();
            switch (season)
            {
                case "зима":
                    Console.WriteLine("Введение во храм Пресвятой Богородицы - 4 декабря \nДень великомученицы Екатерины - 7 декабря\nПразднование иконы Божьей Матери Знамение - 10 декабря\nДень апостола Андрея Первозванного - 13 декабря\nДень Святителя Николая - 19 декабря\nРождество Христово - 7 января\nСвятки – с 6 до 19 января");
                    break;
                case "весна":
                    Console.WriteLine("Масленица — 28.02.-06.03. ( \nДень воссоединения Крыма с Россией(выходной день в Республике Крым) — 18 марта\nДень моряка - подводника — 19 марта\nВсемирный день поэзии — 21 марта\nДень Балтийского моря — 22 марта\nЧас Земли(экологическая акция) — 26 марта(в 2022 году)");
                    break;
                case "лето":
                    Console.WriteLine("Иван Купала Праздник Иван Купала. Фотография: Валерий Матыцин / ТАСС ...\nЫсыах Праздник Ысыах.\nСабантуй Праздник Сабантуй.\nСемык Геннадий Петухов.");
                    break;
                case "осень":
                    Console.WriteLine("8 сентября - Праздник Рода и Рожаниц\n21 сентября – Праздник Сварога\n22 сентября – Праздник Лады\nПоследняя пятница октября – Праздник Макошь\n25 ноября – Праздник Марены(Морзана)");
                    break;
                

                default:
                    break;
            }
        }
    }
}
