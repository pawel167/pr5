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
using static System.Math;

namespace WpfApp1
{  
    public partial class FourPage : Page
    {
        public FourPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            answer.Clear();
            if (!int.TryParse(textbox1.Text, out int x))
            {
                MessageBox.Show("Поле А только число!");
            }
            int y;
            if (x >= 0 && x < 1)
            {
                y = (int)(Pow(Pow(x, 3) + 3, 3) - Sqrt(0.5 * PI + x));
                answer.Text += "y =" + y;
            }
        }
    }
}
