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
    /// Логика взаимодействия для ThreePage.xaml
    /// </summary>
    public partial class ThreePage : Page
    {
        public ThreePage()
        {
            InitializeComponent();
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            answer.Clear();
            if (!double.TryParse(textbox1.Text, out double a))
            {
                MessageBox.Show("Поле А только число!");
            }
            if (!double.TryParse(textbox2.Text, out double b))
            {
                MessageBox.Show("Поле B только число!");
            }
            if (!double.TryParse(textbox3.Text, out double c))
            {
                MessageBox.Show("Поле C только число!");
            }
            if (a < b && a < c && b < c)
            {
                a *= 2;
                b *= 2;
                c *= 2;
            }
            else
            {
                a -= a;
                b -= b;
                c -= c;
            }
            answer.Text += $" а = {a}, b = {b}, c = {c}";
        }
    }
}
