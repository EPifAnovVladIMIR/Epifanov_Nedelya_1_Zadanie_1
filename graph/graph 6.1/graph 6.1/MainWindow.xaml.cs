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

namespace graph_6._1
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

                
                int N = Convert.ToInt32(sa.Text);
                int[] arr = new int[N];
                Random rand = new Random();
                answer.Text = Convert.ToString("");
                for (int i = 0; i < N; i++)
                {
                    arr[i] = rand.Next(0, 10);

                    answer.Text = Convert.ToString(arr[i] + " ");
                }
                
                
                int X = Convert.ToInt32(b.Text); ;
                
                for (int i = 0; i < N; i++)
                {
                    if (arr[i] < X) arr[i] = (int)Math.Pow(arr[i], 2);
                    answer2.Text = Convert.ToString(arr[i] + " ");
                }
                Console.ReadKey();
            }
        }

    }
}






