using System;

namespace PZ_20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string text = Console.ReadLine();
            StringRead(text);
        }

        static void StringRead(string text)
        {
            string result = "";
            for (int i = 0; i < text.Length; i++)
            {
                if (Char.IsUpper(text[i]))
                    result += text[i].ToString().ToLower();
                else
                    result += text[i].ToString().ToUpper();
                
            }
            Console.WriteLine(result);
        }
    }
}
