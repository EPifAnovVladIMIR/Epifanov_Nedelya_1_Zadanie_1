using System;

namespace ConsoleApp12_c_1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter money values (denomination numberOfBills): ");
                Money money = (Money)Console.ReadLine();

                Console.WriteLine($"Values get by index: {money[0]} {money[1]}");

                Console.WriteLine((string)money);
                money++;
                Console.WriteLine((string)money);
                money--;
                Console.WriteLine((string)money);
                Console.WriteLine($"Number of biils is not zero: {!money}");
                money += 10;
                Console.WriteLine($"+= operation: {money}");
            }
            catch
            {
                Console.WriteLine("Error");
            }
        }
    }
}
