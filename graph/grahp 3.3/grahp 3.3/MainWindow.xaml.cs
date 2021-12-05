using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace grahp_3._3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void h_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void vi4et_Click(object sender, RoutedEventArgs e)
        { }
          
    
        class Program
        {
            static void Main(string[] args)
            {

                double A, B, H, x;
                A = Convert.ToInt32(J.Text);
                B = Convert.ToInt32(I.Text);
                H = Convert.ToInt32(P.Text);

                {
                    f(x, out double y);
                    answer.Text = Convert.ToString($"f({x,5:F})={y,10:F2}");
                }
                Console.Read();
            }
            static void f(double a, double b, double h)
            {
                double f = 0;
                for (double x = a; x <= b; x += h)
                {
                    if (Math.Abs(x) <= 0.1)
                        f = x * x * x - 0.1;
                    else if (Math.Abs(x) <= 0.2)
                        f = 0.2 * x - 0.2;
                    else if (Math.Abs(x) > 0.2)
                        f = x * x * x + 0.1;
                    Console.WriteLine("f({0,5:F})={1,10:F2}", x, f);
                }
            }
            static void f(double x, out double y)
            {
                double a = 10;
                y = x < 0
                ? 0
                : x >= 0 & x != 1
                ? x * x + 1
                : 1;
            }
        }

        private void J_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }

}
    

