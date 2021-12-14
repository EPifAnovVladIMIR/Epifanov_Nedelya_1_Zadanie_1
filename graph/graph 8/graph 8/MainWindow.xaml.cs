using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace graph_8
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
             
            {
                _= Convert.ToString(a);
                string str = Convert.ToString(с);
                string ysl = @"(^|\s).\s";
                string prob = " ";
                Regex regex = new Regex(ysl);
                string rez = regex.Replace(str, prob);
                b.Text = Convert.ToString(rez);
               
            }
        }
    }

}


