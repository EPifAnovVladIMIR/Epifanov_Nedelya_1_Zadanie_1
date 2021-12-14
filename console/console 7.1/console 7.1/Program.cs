using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cons
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string input = Console.ReadLine();
            int ind = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input.Substring(i, 1) != " ")
                    ind++;
            }
            Console.WriteLine("Количество букв равно {0}", ind);
            Console.ReadKey();
        }
    }
}