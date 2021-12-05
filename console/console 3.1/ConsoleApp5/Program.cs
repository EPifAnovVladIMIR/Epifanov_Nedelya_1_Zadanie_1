static double F(double x)
{
    return Math.Cos(2 * x) + Math.Sin(x - 3);
}
double a = Convert.ToDouble(Console.ReadLine());
double b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(F(a) < F(b) ? "a" : "b");
