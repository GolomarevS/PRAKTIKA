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
            double x, x2, y, a;
            x = Convert.ToDouble(.Text); /// Минимум
            x2 = Convert.ToDouble(.Text); /// Максимум
            a = Convert.ToDouble(.Text); /// Шаг


            .Text += Convert.ToString("x" + "  |  " + "y" + "\n"); ///окновывода
            while (x <= x2)
            {
                y = -0.23 * x * x + x;
                .Text += Convert.ToString(x + "  |  " + y + "\n"); ///окновывода
                x += a;
            }
        }
    }
}
