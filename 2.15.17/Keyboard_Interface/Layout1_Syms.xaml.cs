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
using System.Windows.Shapes;

namespace Keyboard_Interface
{
    /// <summary>
    /// Interaction logic for Layout1_Syms.xaml
    /// </summary>
    public partial class Layout1_Syms : Window
    {
        public Layout1_Syms()
        {
            InitializeComponent();
            this.Background = new SolidColorBrush(Color.FromRgb(Properties.Settings.Default.themeRGB, Properties.Settings.Default.themeRGB, Properties.Settings.Default.themeRGB));
        }

        private void close_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void a_Click (object sender, RoutedEventArgs e)
        {
            input.AppendText("A");
        }
        private void zero_Click(object sender, RoutedEventArgs e)
        {
            input.AppendText("0");
        }
        private void one_Click(object sender, RoutedEventArgs e)
        {
            input.AppendText("1");
        }
        private void two_Click(object sender, RoutedEventArgs e)
        {
            input.AppendText("2");
        }
        private void three_Click(object sender, RoutedEventArgs e)
        {
            input.AppendText("3");
        }
        private void four_Click(object sender, RoutedEventArgs e)
        {
            input.AppendText("4");
        }
        private void five_Click(object sender, RoutedEventArgs e)
        {
            input.AppendText("5");
        }
        private void six_Click(object sender, RoutedEventArgs e)
        {
            input.AppendText("6");
        }
        private void seven_Click(object sender, RoutedEventArgs e)
        {
            input.AppendText("7");
        }
        private void eight_Click(object sender, RoutedEventArgs e)
        {
            input.AppendText("8");
        }
        private void nine_Click(object sender, RoutedEventArgs e)
        {
            input.AppendText("9");
        }
        private void bksp_Click(object sender, RoutedEventArgs e)
        {
            if (input.Text.Length != 0)
                input.Text = input.Text.Remove(input.Text.Length - 1, 1);
        }
        private void sym_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
