using System;

namespace PZ_21
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string clientFIO = Console.ReadLine();
            int validity = int.Parse(Console.ReadLine());
            int secureCode = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();

            card cardInfo = new card(number,clientFIO,validity,secureCode,type);
            card cardInfo1 = new card();
            card cardInfo2 = new card(number, validity, secureCode, type);
            card cardInfo3 = new card(number, clientFIO, secureCode, type);
            Console.WriteLine("\n");
            cardInfo.PrintInfo();
            Console.WriteLine("\n");
            cardInfo1.PrintInfo();
            Console.WriteLine("\n");
            cardInfo2.PrintInfo();
            Console.WriteLine("\n");
            cardInfo3.PrintInfo();
            


        }
    }
}
