using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System;
namespace Hello
{
    class Program
    {
        static double f(double x)
        {
            double y;
            if (x <= 0.1) y = x * x * x - 0.1;
            else if (x <= 0.2) y = 0.2 * x - 0.1;
            else y = x * x * x + 0.1;
            return y;
        }

        static void Main(string[] args)
        {
            Console.Write("a=");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b=");
            double b = double.Parse(Console.ReadLine());
            Console.Write("h=");
            double h = double.Parse(Console.ReadLine());
            for (double i = a; i <= b; i += h)
                Console.WriteLine("f({0:f2})={1:f4}", i, f(i));
        }
    }
}

    static void f(double x, out double y)
        
    double a = 10;
    
    
        y = x <= 0,1
 x * x * x - 0,1
            : x <= 0.2
            ? y = 0.2 * x - 0.1
            : y = x * x * x + 0.1;


    



