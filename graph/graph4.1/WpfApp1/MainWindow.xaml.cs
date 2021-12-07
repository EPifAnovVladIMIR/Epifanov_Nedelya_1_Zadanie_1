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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            int rec(int n, int m)
            {
                if (n == 0)
                    return (m + 1);
                if (m == 0)
                    return rec(n - 1, 1);
                return rec(n - 1, rec(n, m - 1));
            }
            void nerec(int n, int m)
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

            void Main()
            {


                nerec(1, 2);
                Console.WriteLine("Рекурсивный метод: " + rec(1, 1));

                Console.ReadKey();
            }
        }
    }

}
    

