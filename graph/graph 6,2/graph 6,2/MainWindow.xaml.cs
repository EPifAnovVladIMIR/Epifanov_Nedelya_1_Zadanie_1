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

namespace graph_6_2
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
                double[] array = { 1, 2, 3, 4, 8, 4, 9 };

                int maxInd = 0;

                for (int i = 0; i < array.Length; i++)
                    if (array[i] > array[maxInd])
                        maxInd = i;

                double temp = array[0];
                array[0] = array[maxInd];
                array[maxInd] = temp;

                answer.Text = Convert.ToString((" ", array));
                Console.ReadKey();
            }
        }
    }

}

    

