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
    /// Логика взаимодействия для SecondPage.xaml
    /// </summary>
    public partial class SecondPage : Page
    {
        public SecondPage()
        {
            InitializeComponent();
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            answer.Clear();
            if (!double.TryParse(textbox1.Text, out double y))
            {
                MessageBox.Show("Поле А только число!");
            }
            if (!double.TryParse(textbox2.Text, out double z))
            {
                MessageBox.Show("Поле B только число!");
            }           
            if (z > y)
            {
                if (z > y)
                {
                    y = z;
                }
                else
                {
                    z = y;
                }
            }
            else
            {
                z = 0;
                y = 0;
            }
            answer.Text += $"новые значения z = {z}, y = {y}";
        }
    }
}
