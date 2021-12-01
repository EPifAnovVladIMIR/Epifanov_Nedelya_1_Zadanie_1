using System;
namespace magamed
{
    {
        static void Main(string[] args)
    {

        int i = 1;
        do
        {
            ++i;
            int e = i * 453;
            Console.WriteLine(i + "кг = " + (e) + " фунтов");
        }
        while (i < 10);
        Console.ReadKey();
    }
}
