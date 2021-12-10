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

namespace graph_6._3
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            void Main(string[] args)
            {
                int n = 0, z = 0;

                n = Convert.ToInt32(A.Text); ;

                
                z = Convert.ToInt32(B.Text); ;


                int[,] Mass = new int[n, n];
                Random R = new Random();

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    { Mass[i, j] = R.Next(0, 30); }
                }


                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        answer.Text = Convert.ToString(Mass[i, j] + " ");
                        if (j + 2 > n) { Console.WriteLine(); }
                    }
                }


                string[] mass1 = new string[n * n];

                for (int i = 0; i < n * n; i++) { if (mass1[i] != null) { Console.WriteLine(mass1[i]); }; }
             
                float sum = 0, num = 0, CAdiag;
                for (int i = n - 1; i >= 0; i--) { sum += Mass[i, n - 1 - i]; num++; }
                CAdiag = sum / num;

                answer1.Text = Convert.ToString("Количество элементов на диагонале: " + num + "\nСумма диагонали: " + sum + "\nСреднее арифметическое: " + CAdiag);

                Console.ReadKey();
            }
        }
    }

}
    

