using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задачасшарп
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0, z = 0;
            Console.WriteLine("Введите размер массива:");
            n = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Введите число для сравнения:");
            z = Convert.ToInt16(Console.ReadLine());


            int[,] Mass = new int[n, n];
            Random R = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                { Mass[i, j] = R.Next(0, 30); }
            }


            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(Mass[i, j] + " ");
                    if (j + 2 > n) { Console.WriteLine(); }
                }
            }


            string[] mass1 = new string[n * n];

            for (int i = 0; i < n * n; i++) { if (mass1[i] != null) { Console.WriteLine(mass1[i]); }; }
            Console.Write("\n-------— СА на диагонале-----\n");

            float sum = 0, num = 0, CAdiag;
            for (int i = n - 1; i >= 0; i--) { sum += Mass[i, n - 1 - i]; num++; }
            CAdiag = sum / num;

            Console.Write("Количество элементов на диагонале: " + num + "\nСумма диагонали: " + sum + "\nСреднее арифметическое: " + CAdiag);

            Console.ReadKey();
        }
    }
}