using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = { 1, 2, 3, 4, 8, 4, 9 };

            int maxInd = 0;

            for (int i = 0; i < array.Length; i++)
                if (array[i] > array[maxInd])
                    maxInd = i;

            double temp = array[0];
            array[0] = array[maxInd];
            array[maxInd] = temp;

            Console.WriteLine(string.Join(" ", array));
            Console.ReadKey();
        }
    }
}