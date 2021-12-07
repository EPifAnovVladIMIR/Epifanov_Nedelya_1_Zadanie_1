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

namespace gpaph_5
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
      
    
       
        {
             double f(double x)
            {
                try
                {
                    //если х не попадает в область определения, то генерируется исключение
                    if (x == -1) throw new Exception();
                    else return Math.Sqrt(5 - x * x * x);
                }
                catch
                {
                    throw;
                }
            }
            void Main(string[] args)
            {
                try
                {
                        double X, Y ,Z;
                        X = Convert.ToInt32(a.Text);
                        Y = Convert.ToInt32(b.Text);
                        Z = Convert.ToInt32(h.Text);

                        for (double i = X; i <= Y; i += Z)
                        try
                        {
                                answer.Text = Convert.ToString(f(i));
                        }
                        catch
                        {
                                answer.Text = Convert.ToString(i);
                        }
                }
                catch (FormatException)
                {
                        answer.Text = Convert.ToString("Неверный формат ввода данных");
                }
                catch
                {
                        answer.Text = Convert.ToString("Неизвестная ошибка");
                }
            }
        }
    }

}
    }

