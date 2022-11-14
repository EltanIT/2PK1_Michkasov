using System;
using System.Linq;
namespace PZ_11
{
    class Program
    {
        static void Main(string[] args)
        {

            string text = "Мы все знаем, что яблоко полезно для здоровья, поэтому давайте сделаем из него полезный салат. Очистите яблоко, поэтому удалите сердцевину, из порежьте кубиками";
            String[] charsToRemove = { "," };
            foreach (var item in charsToRemove)
            {
                text = text.Replace(item, string.Empty);
            }

            string text1 = text.Substring(0, text.IndexOf('.'));
            string[] text1Arr = text1.Split(' ');
            string text2 = text.Substring(text.IndexOf('.') + 2, text.Length - text.IndexOf('.') -2 );
            string[] text2Arr = text2.Split(' ');

            foreach (var item in text1Arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            foreach (var item in text2Arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < text1Arr.Length; i++)
            {
                for (int k = 0; k < text2Arr.Length; k++)
                {
                    if (text2Arr[k].Contains(text1Arr[i]))
                    {
                        Console.WriteLine(text2Arr[k]);
                    }
                }
            }
        }
    }
}
