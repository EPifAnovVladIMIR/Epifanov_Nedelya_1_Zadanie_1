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

namespace graph_3._2
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

        private void otvet_Click(object sender, RoutedEventArgs e)
        {
             double f(double x)
            {
                double A, B, H, y;
                A = Convert.ToInt32(a.Text);
                B = Convert.ToInt32(b.Text);
                H = Convert.ToInt32(h.Text);
                if (x <= 0.1) y = x * x * x - 0.1;
                else if (x <= 0.2) y = 0.2 * x - 0.1;
                else y = x * x * x + 0.1;
                return y;
                for (double i = A; i <= B; i += H)
                
            

                
                   vivod.Text = Convert.ToString(("f({0:f2})={1:f4}", i, f(i)));
            }
        }
    }

}
    

