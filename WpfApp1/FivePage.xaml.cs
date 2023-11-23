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
    /// Логика взаимодействия для FivePage.xaml
    /// </summary>
    public partial class FivePage : Page
    {
        public FivePage()
        {
            InitializeComponent();
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            answer.Clear();
            if (!int.TryParse(textbox1.Text, out int x))
            {
                MessageBox.Show("Поле А только число!");
            }
            if (!int.TryParse(textbox1.Text, out int y))
            {
                MessageBox.Show("Поле А только число!");
            }
            if (y < -Math.Abs(x) && y > -100)
            {
                answer.Text += "да";
            }
            if (y == -Math.Abs(x) && y == -100)
            {
                answer.Text += "на границе";
            }
            else
            {
                answer.Text += "нет";
            }
        }
    }
}
