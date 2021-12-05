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

        private void vivod_Click(object sender, RoutedEventArgs e)

        {
            double A, B;
            A = Convert.ToInt32(X.Text);
            B = Convert.ToInt32(Y.Text);
             double F(double x)
            {
                return Math.Cos(2 * x) + Math.Sin(x - 3);
            }

            otvet.Text = Convert.ToString(F(A) < F(B) ? "a" : "b");

        }
    }
}


