using System;
namespace magamed
{
    class program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i + "кг = " + (i * 453) + " фунтов");
            }
            Console.ReadKey();
        } 
    }
}