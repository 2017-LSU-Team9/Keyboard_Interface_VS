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

        private void a_Click(object sender, RoutedEventArgs e)
        {
            //if(Properties.Settings.Default.CAPS == true){
            input.AppendText("A");
            // Call function to show all lowercase
            //Properties.Settings.Default.CAPS = false;
            //}

            //else if(Properties.Settings.Default.CAPSkey == true){
            // input.AppendText("A");
            //}

            //else
            //{
            // input.AppendText("a");
            //}
        }

        private void zero_Click(object sender, RoutedEventArgs e)
        {
            input.AppendText("0");
        }
        private void bksp_Click(object sender, RoutedEventArgs e)
        {
            input.Text = input.Text.Remove(input.Text.Length - 1, 1);
        }
    }
}
