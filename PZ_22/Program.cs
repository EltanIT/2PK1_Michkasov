using System;

namespace PZ_22
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date1 = new DateTime(2023, 01, 02);
            DateTime date2 = new DateTime(2023, 06, 23);
            DateTime date3 = new DateTime(2021, 10, 15);
            Card c1 = new Card(id: 1, number: 15123445115787275452, clientFIO: "Мичкасов Георгий Александрович", validity: date1, secureCode: 013, type: "Дебетовая карта");
            Card c2 = new Card(id: 1, number: 13558293451953475823, clientFIO: "", validity: date2, secureCode: 013, type: "Дебетовая карта");
            Card c3 = new Card(id: 1, number: 16753478625934758623, clientFIO: "Мичкасов Георгий Александрович", validity: date3, secureCode: 013, type: "");
            c1.PrintInfo();
            Console.WriteLine("\n");
            c2.PrintInfo();
            Console.WriteLine("\n");
            c3.PrintInfo();

            Console.WriteLine($"Всего карт: {Card.cardcount = c1.id + c2.id + c3.id}\nКол-во карт, срок действия которых истекает в этом году: {Card.cardcountTerm}");
        }
    }
}
