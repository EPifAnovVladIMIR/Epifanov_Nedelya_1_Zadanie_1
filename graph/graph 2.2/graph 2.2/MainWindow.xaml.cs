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

namespace graph_2._2
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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void b_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void m_Click(object sender, RoutedEventArgs e)
        {
            string A;
            A = Convert.ToString(a.Text);

            switch (A)
            {
                case "6":
                    b.Text = Convert.ToString("Шестерка");
                    break;
                case "7":
                    b.Text = Convert.ToString("Семерка");
                    break;
                case "8":
                    b.Text = Convert.ToString("Восьмерка");
                    break;
                case "9":
                    b.Text = Convert.ToString("Девятка");
                    break;
                case "10":
                    b.Text = Convert.ToString("Десятка");
                    break;
                case "11":
                    b.Text = Convert.ToString("Валет");
                    break;
                case "12":
                    b.Text = Convert.ToString("Дама");
                    break;
                case "13":
                    b.Text = Convert.ToString("Король");
                    break;
                case "14":
                    b.Text = Convert.ToString("Туз");
                    break;
                default:
                    b.Text = Convert.ToString("Вы ошиблись!");
                    break;
            }

        }
    }






