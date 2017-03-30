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
    /// Interaction logic for close_confirm.xaml
    /// </summary>
    public partial class close_confirm : Window
    {
        public close_confirm()
        {
            InitializeComponent();
        }

        private void yes_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void settings_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            //Application.Current.Windows[Application.Current.Windows.Count - 1].Close();
            System.Diagnostics.Process.Start(Application.ResourceAssembly.Location);
            Application.Current.Shutdown();
            Settings settings = new Keyboard_Interface.Settings();
            settings.Show();
        }
    }
}
