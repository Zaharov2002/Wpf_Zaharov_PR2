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

namespace Wpf_Zaharov_PR2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        
        }

        private void Win1_Click(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.Show();
        }

        private void Win2_Click(object sender, RoutedEventArgs e)
        {
            Window2 window2 = new Window2();
            window2.Show();
        }

        private void Win3_Click(object sender, RoutedEventArgs e)
        {
            Window3 window3 = new Window3();
            window3.Show();
        }

        private void Win4_Click(object sender, RoutedEventArgs e)
        {
            Window4 window4 = new Window4();
            window4.Show();
        }

        private void Win5_Click(object sender, RoutedEventArgs e)
        {
            Window5 window5 = new Window5();
            window5.Show();
        }

        private void Win6_Click(object sender, RoutedEventArgs e)
        {
            Window6 window6 = new Window6();
            window6.Show();
        }

        private void Win7_Click(object sender, RoutedEventArgs e)
        {
            Window7 window7 = new Window7();
            window7.Show();
        }

        private void Win8_Click(object sender, RoutedEventArgs e)
        {
            Window8 window8 = new Window8();
            window8.Show();
        }

        private void Win9_Click(object sender, RoutedEventArgs e)
        {
            Window9 window9 = new Window9();
            window9.Show();
        }

        private void Win10_Click(object sender, RoutedEventArgs e)
        {
            Window10 window10 = new Window10();
            window10.Show();
        }
    }
}
