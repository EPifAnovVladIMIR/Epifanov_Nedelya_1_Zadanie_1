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

namespace WpfApp1
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
        

    {
        class Class
        {
            static int[][] Input()
            {
                Convert.ToInt32("введите размерность массива");
                Convert.ToInt32("n = ");
                int n = int.Parse(Console.ReadLine());
                int[][] a = new int[n][];
                for (int i = 0; i < n; ++i)
                {
                    a[i] = new int[n];
                    for (int j = 0; j < n; ++j)
                    {
                        Console.Write("a[{0},{1}]= ", i, j);
                        a[i][j] = int.Parse(Console.ReadLine());
                    }
                }
                return a;
            }

            static void Print1(int[] a)
            {
                for (int i = 0; i < a.Length; ++i)
                    Console.Write("{0,5} ", a[i]);
            }

            static void Print2(int[][] a)
            {
                for (int i = 0; i < a.Length; ++i, Convert.ToInt32())
                    for (int j = 0; j < a[i].Length; ++j)
                        Console.Write("{0,5} ", a[i][j]);
            }

            static int Max(int[] a)
            {
                int max = a[0];
                for (int i = 1; i < a.Length; ++i)

                    if (a[i] > max) { max = a[i]; }
                return max;
            }

            static void Main()
            {
                int[][] myArray = Input();
               
                Print2(myArray);
                int[] rez = new int[myArray.Length];
                for (int i = 0; i < myArray.Length; ++i)
                    rez[i] = Max(myArray[i]);
                
                Print1(rez);
            }
        }
    }

}
}
