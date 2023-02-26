using System;

namespace PZ_23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вариант-18\n");
            DateTime date1 = new DateTime(2023, 01, 02);
            DateTime date2 = new DateTime(2023, 06, 23);
            DateTime date3 = new DateTime(2021, 10, 15);
            BlockedCard c1 = new BlockedCard(id: 1, number: 15123445115787275452, clientFIO: "Мичкасов Георгий Александрович", validity: date1, secureCode: 13, type: "Дебетовая карта");
            BlockedCard c2 = new BlockedCard(id: 1, number: 13558293451953475823, clientFIO: "", validity: date2, secureCode: 123, type: "Дебетовая карта");
            BlockedCard c3 = new BlockedCard(id: 1, number: 16753478625934758623, clientFIO: "Мичкасов Георгий Александрович", validity: date3, secureCode: 135, type: "");
            c1.Print();
            Console.WriteLine($"Причина блокировки: {c1.reasonBlock}\n");
            c2.Print();
            Console.WriteLine($"Причина блокировки: {c2.reasonBlock}\n");
            c3.Print();
            Console.WriteLine($"Причина блокировки: {c3.reasonBlock}\n");

            Console.WriteLine($"Всего карт: {Card.cardcount = c1.id + c2.id + c3.id}\nКол-во карт, срок действия которых истекает в этом году: {Card.cardcountTerm}\n");

            Console.WriteLine("Обновленная информация по 1 карте:");
            Card card = new BlockedCard();
            card.PrintInfo();
        }
    }
}
