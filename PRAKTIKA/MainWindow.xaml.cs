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

namespace PRAKTIKA
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

        private void Вычислить_Click(object sender, RoutedEventArgs e)
        {
            Double x, x2, y, a;
            x = Convert.ToDouble(Minimum.Text);
            x2 = Convert.ToDouble(Maximum.Text);
            a = Convert.ToDouble(S.Text);


            Otvet.Text += Convert.ToString("x" + "  |  " + "y" + "\n");
            while (x <= x2)
            {
                y = -0.23 * x * x + x;
                Otvet.Text += Convert.ToString(x + "  |  " + y + "\n");
                x += a;
            }
        }
    }
}
