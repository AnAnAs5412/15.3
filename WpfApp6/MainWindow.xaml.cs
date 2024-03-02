using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
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

namespace WpfApp6
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
        private void Lable1(double x, double y)
        {
            double newX = objects.Margin.Left + x;
            double newY = objects.Margin.Top + y;

            if (newX >= 0 && newX + objects.ActualWidth <= this.ActualWidth)
            {
                objects.Margin = new Thickness(newX, objects.Margin.Top, 0, 0);
            }
            if (newY >= 0 && newY + objects.ActualHeight <= this.ActualHeight)
            {
                objects.Margin = new Thickness(objects.Margin.Left, newY, 0, 0);
            }
            if (newX <= this.ActualWidth && newX + objects.ActualWidth <= this.ActualWidth)
            {
                objects.Margin = new Thickness(newX, objects.Margin.Top, 0, 0);
            }
            if (newY <= this.ActualHeight && newY + objects.ActualHeight <= this.ActualHeight)
            {
                objects.Margin = new Thickness(objects.Margin.Left, newY, 0, 0);
            }
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {

            Lable1(0, -10);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Lable1(0, 10);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Lable1(10, 0);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Lable1(-10, 0);
        }
    }
}
