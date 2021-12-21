using System;

namespace ConsoleApp11_c_1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите номинал и количество купюр: ");
                int first = int.Parse(Console.ReadLine());
                int second = int.Parse(Console.ReadLine());

                Money money = new Money(first, second);

                Console.WriteLine(money);
                Console.WriteLine($"Money summ: {money.MoneySumm}");
                Console.WriteLine($"Money is enought to buy on 110: {money.IsEnought(110)}");
                Console.WriteLine($"How much thing can buy on 113: {money.GetNumberOfProducts(113)}");
            }
            catch
            {
                // вывод сообщения об ошибке
                Console.WriteLine("exception");
            }
        }
    }
}
