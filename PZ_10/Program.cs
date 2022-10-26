using System;
using System.Text.RegularExpressions;

namespace PZ_10
{
    class Program
    {
        static void Main(string[] args)
        {
            String str = Console.ReadLine();
            var result1 = new Regex("[0-9]+").Matches(str);
            foreach (var match in result1) 
                Console.WriteLine(match);
        }
    }
}
