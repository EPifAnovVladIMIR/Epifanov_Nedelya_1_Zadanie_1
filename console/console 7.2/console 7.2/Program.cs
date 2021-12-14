using System;
using System.IO;
using System.Text.RegularExpressions;

namespace lab
{
    class Program
    {
        const string LastChar = "е";// Ваш символ

        public static void Main()
        {
            string msg = "Осмысленное сообщение из разных слов.";
            msg = (new Regex("[а-яА-Я]+" + LastChar)).Replace(msg, "").Trim();
            Console.WriteLine(msg);
            Console.ReadLine();
        }
    }
}
