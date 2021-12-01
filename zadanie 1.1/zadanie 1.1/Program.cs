using System;
namespace Average_GeametricMean
{
    class Program
    {
        public static void Main(string[] args)
        {
            int a, b;
            //Ввод нчальных данных
            Console.Write("Enter a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter b: ");
            b = Convert.ToInt32(Console.ReadLine());
            //модуль числа
            if (a < 0)
                a = -a;
            if (b < 0)
                b = -b;
           //Среднее геометрическое
            Console.WriteLine("Среднее геометрическое модулей числа a и b: {0:F}", Math.Sqrt(a * b));
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}

