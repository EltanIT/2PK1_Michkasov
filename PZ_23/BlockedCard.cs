using System;
using System.Collections.Generic;
using System.Text;

namespace PZ_23
{
    class BlockedCard : Card
    {
       public string reasonBlock;
        public BlockedCard()
        {

        }
        public BlockedCard(byte id, ulong number, string clientFIO, DateTime validity, byte secureCode, string type)
        {
            this.id = id;
            this.number = number;
            this.clientFIO = clientFIO;
            this.validity = validity;
            this.secureCode = secureCode;
            this.type = type;

        }
        public BlockedCard(byte id, string clientFIO, DateTime validity, string type)
        {
            this.id = id;
            number = 892561234;
            this.clientFIO = clientFIO;
            this.validity = validity;
            secureCode = 033;
            this.type = type;

        }

        public void Print()
        {
            ExaminationCard();
            Console.WriteLine($"номер карты: {number}\nФИО клиента: {clientFIO}\nСрок действия: {validity}\nКод безопасности: {secureCode}\nТип карты: {type}\n");
        }
        public void ExaminationCard()
        {
            if (clientFIO == String.Empty)
            {
                reasonBlock = "имя некорректно";
            }
            else if (type == String.Empty)
            {
                reasonBlock = "тип карты некорректен";
            }
            else if (number.ToString().Length != 20)
            {
                reasonBlock = "номер карты некорректен";
            }
            else if (secureCode.ToString().Length != 3)
            {
                reasonBlock = "код безопасности некорректен";
            }
            if (validity < new DateTime(2022, 01, 01) || validity > new DateTime(2026, 01, 01))
            {
                reasonBlock = "срок годности карты некорректен";
            }
            else if (validity.Year == 2023)
            {
                cardcountTerm++;
            }
        }
        public override void PrintInfo()
        {
            Console.WriteLine($"номер карты: 1512344511578727545\nФИО клиента: Мичкасов Георгий Александрович\nСрок действия: {validity}\nКод безопасности: 13\nТип карты: Дебетовая карта\n");
        }
    }
}
