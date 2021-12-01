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

namespace WpfApp2
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


            double A, B;
            A = Convert.ToInt32(a.Text);
            B = Convert.ToInt32(b.Text);

            if (A < 0)
                    A = -A;
            if (A < 0)
                B = -B;

            text.Text = Convert.ToString("Среднее геометрическое модулей числа a и b: {0:F}", Math.Sqrt(A* B));
            text.Text = Convert.ToString("Press any key to continue . . . ");
               
            }
        }
    }

