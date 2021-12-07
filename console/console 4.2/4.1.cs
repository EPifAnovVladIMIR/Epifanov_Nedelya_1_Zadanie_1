using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {

        static int rec(int n, int m)
        {
            if (n == 0)
                return (m + 1);
            if (m == 0)
                return rec(n - 1, 1);
            return rec(n - 1, rec(n, m - 1));
        }
        static void nerec(int n, int m)
        {
            int i, j;
            int[,] A = new int[n, m];

            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                {
                    if (i == 0)
                        A[i, j] = j + 1;
                    else
                      if (j == 0)
                        A[i, j] = A[i - 1, 1];

                    else
                        A[i, j] = A[i - 1, A[i, j - 1]];
                }


            }
        }

        static void Main()
        {


            nerec(1, 2);
            Console.WriteLine("Рекурсивный метод: " + rec(1, 1));

            Console.ReadKey();
        }
    }
}
