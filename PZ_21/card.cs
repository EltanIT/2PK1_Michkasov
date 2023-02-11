using System;
using System.Collections.Generic;
using System.Text;

namespace PZ_21
{
    class card
    {
        int number;
        string clientFIO;
        int validity;
        int secureCode;
        string type;

        public card(int number, string clientFIO, int validity, int secureCode, string type)
        {
            this.number = number;
            this.clientFIO = clientFIO;
            this.validity = validity;
            this.secureCode = secureCode;
            this.type = type;
        }   
        public card()
        {
            number = 143280;
            clientFIO = "Мичкасов Георгий Александрович";
            validity = 4;
            secureCode = 432;
            type = "Дебетовая";
        }
        public card(int number, string clientFIO, int secureCode, string type)
        {
            this.number = number;
            this.clientFIO = clientFIO;
            validity = 4;
            this.secureCode = secureCode;
            this.type = type;
        }
        public card(int number, int validity, int secureCode, string type)
        {
            this.number = number;
            clientFIO = "Мичкасов Георгий Александрович";
            this.validity = validity;
            this.secureCode = secureCode;
            this.type = type;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"номер карты: {number}\nФИО: {clientFIO}\nСрок действия: {validity} года\nКод безопасности: {secureCode}\nТип карты: {type}");
        }
    }

}
