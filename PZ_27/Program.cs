using System;

namespace PZ_27
{
    class Program
    {

        const int flight_count = 7;
        static void Main(string[] args)
        {
            AEROFLOT[] AIPORT = new Program.AEROFLOT[flight_count];

            getValue(AIPORT);
            sortValue(AIPORT);
            destinationToWrite(AIPORT);
        }

        struct AEROFLOT
        {
            public string NAZN;
            public int NUMR;
            public string TIP;
        }

        static void getValue(AEROFLOT[] AIPORT)
        {
            for (int i = 0; i < flight_count; i++)
            {
                AEROFLOT Aiport = new AEROFLOT();

                Console.Write("Введите название пункта назначения: ");
                Aiport.NAZN = Console.ReadLine();
                Console.Write("Введите номер рейса(только числа): ");
                Aiport.NUMR =int.Parse(Console.ReadLine());
                Console.Write("Введите тип самолета: ");
                Aiport.TIP = Console.ReadLine();
                Console.WriteLine();

                AIPORT[i] = Aiport;
            }
            Console.WriteLine("_________________________");
        }

        static void sortValue(AEROFLOT[] AIPORT)
        {
            Array.Sort(AIPORT, (x, y) => String.Compare(x.NAZN, y.NAZN));
            Console.WriteLine("Отсортированные данные:\n");

            for (int i = 0; i < flight_count; i++)
            {
                Console.WriteLine("название пункта назначения: " + AIPORT[i].NAZN);
                Console.WriteLine("номер рейса: " + AIPORT[i].NUMR);
                Console.WriteLine("тип самолета: " + AIPORT[i].TIP);
                Console.WriteLine();
            }
            Console.WriteLine("_________________________");
        }

        static void destinationToWrite(AEROFLOT[] AIPORT)
        {
            bool fligths_bool = false;

            Console.WriteLine("Введите название типа самолета");
            string destinationToWrite_String = Console.ReadLine();
            Console.WriteLine($"\nОбслуживаемые самолеты по типу:");
            for (int i = 0; i < AIPORT.Length; i++)
            {
                if (AIPORT[i].TIP == destinationToWrite_String)
                {
                    Console.WriteLine("Имя:" + AIPORT[i].NAZN + "  " + "Номер рейса:"+AIPORT[i].NUMR);
                    fligths_bool = true;
                }
            }
            if (!fligths_bool)
            {
                Console.WriteLine("Таких самолетов и рейсов нет");
            }
            Console.WriteLine("_________________________");
        }
    }
}
