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
    /// Interaction logic for clear_confirm.xaml
    /// </summary>
    public partial class clear_confirm : Window
    {
        public bool clear;

        public clear_confirm()
        {
            InitializeComponent();
        }

        private void yes_Click(object sender, RoutedEventArgs e)
        {
            clear = true;
            this.Close();
        }

        private void no_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
