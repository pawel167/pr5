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
    /// Логика взаимодействия для FirstPage.xaml
    /// </summary>
    public partial class FirstPage : Page
    {
        public FirstPage()
        {
            InitializeComponent();
        }                
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            answer.Clear();
            if (!int.TryParse(textbox1.Text, out int x))
            {
                MessageBox.Show("Введите число!");
            }
            int y, z;
            y = x / 100;
            z = x % 100 / 10;
            if (z > y)
            {
                answer.Text += "больше вторая цифра";
            }
            else
            {
                answer.Text += "больше первая цифра";
            }
        }
    }
}

