using System;
using System.Collections.Generic;
using System.Text;

namespace PZ_23
{
    class Card
    {
        public byte id;
        public ulong number;
        public string clientFIO;
        public DateTime validity;
        public byte secureCode;
        public string type;

        static public int cardcount = 0;
        static public int cardcountTerm = 0;

        public Card()
        {

        }
        public Card(byte id, ulong number, string clientFIO, DateTime validity, byte secureCode, string type)
        {
            this.id = id;
            this.number = number;
            this.clientFIO = clientFIO;
            this.validity = validity;
            this.secureCode = secureCode;
            this.type = type;

        }
        public Card(byte id, string clientFIO, DateTime validity, string type)
        {
            this.id = id;
            number = 892561234;
            this.clientFIO = clientFIO;
            this.validity = validity;
            secureCode = 033;
            this.type = type;

        }
        public virtual void PrintInfo()
        {
            ExaminationCard();
            Console.WriteLine($"номер карты: {number}\nФИО клиента: {clientFIO}\nСрок действия: {validity}\nКод безопасности: {secureCode}\nТип карты: {type}\n");
        }

        public void ExaminationCard()
        {
            if (clientFIO == String.Empty)
            {
                clientFIO = "пустое значение";
            }
            if (type == String.Empty)
            {
                type = "пустое значение";
            }
            if (number.ToString().Length != 20)
            {
                number = 0;
            }
            if (secureCode.ToString().Length != 3)
            {
                secureCode = 0;
            }
            if (validity < new DateTime(2022, 01, 01) || validity > new DateTime(2026, 01, 01))
            {
                validity = new DateTime(0001, 01, 01);
            }
            else if (validity.Year == 2023)
            {
                cardcountTerm++;
            }


        }
    }
}
