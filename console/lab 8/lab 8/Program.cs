using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ввведите строчку");
            string str = Console.ReadLine();
            string ysl = @"(^|\s).\s";
            string prob = " ";
            Regex regex = new Regex(ysl);
            string rez = regex.Replace(str, prob);
            Console.WriteLine(rez);
            Console.ReadKey();
        }
    }
}
 