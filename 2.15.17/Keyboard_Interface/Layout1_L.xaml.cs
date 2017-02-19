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

namespace Keyboard_Interface
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>


    public partial class Layout1_L : Window
    {
        public Layout1_L()
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

        private void b_Click(object sender, RoutedEventArgs e)
        {
            input.AppendText("B");
        }

        private void c_Click(object sender, RoutedEventArgs e)
        {
            input.AppendText("C");
        }

        private void d_Click(object sender, RoutedEventArgs e)
        {
            input.AppendText("D");
        }

        private void e_Click(object sender, RoutedEventArgs e)
        {
            input.AppendText("E");
        }

        private void f_Click(object sender, RoutedEventArgs e)
        {
            input.AppendText("F");
        }

        private void g_Click(object sender, RoutedEventArgs e)
        {
            input.AppendText("G");
        }

        private void h_Click(object sender, RoutedEventArgs e)
        {
            input.AppendText("H");
        }

        private void i_Click(object sender, RoutedEventArgs e)
        {
            input.AppendText("I");
        }

        private void j_Click(object sender, RoutedEventArgs e)
        {
            input.AppendText("J");
        }

        private void k_Click(object sender, RoutedEventArgs e)
        {
            input.AppendText("K");
        }

        private void l_Click(object sender, RoutedEventArgs e)
        {
            input.AppendText("L");
        }

        private void m_Click(object sender, RoutedEventArgs e)
        {
            input.AppendText("M");
        }

        private void n_Click(object sender, RoutedEventArgs e)
        {
            input.AppendText("N");
        }

        private void o_Click(object sender, RoutedEventArgs e)
        {
            input.AppendText("O");
        }

        private void p_Click(object sender, RoutedEventArgs e)
        {
            input.AppendText("P");
        }

        private void q_Click(object sender, RoutedEventArgs e)
        {
            input.AppendText("Q");
        }

        private void r_Click(object sender, RoutedEventArgs e)
        {
            input.AppendText("R");
        }

        private void s_Click(object sender, RoutedEventArgs e)
        {
            input.AppendText("S");
        }

        private void t_Click(object sender, RoutedEventArgs e)
        {
            input.AppendText("T");
        }

        private void u_Click(object sender, RoutedEventArgs e)
        {
            input.AppendText("U");
        }

        private void v_Click(object sender, RoutedEventArgs e)
        {
            input.AppendText("V");
        }

        private void w_Click(object sender, RoutedEventArgs e)
        {
            input.AppendText("W");
        }

        private void x_Click(object sender, RoutedEventArgs e)
        {
            input.AppendText("X");
        }

        private void y_Click(object sender, RoutedEventArgs e)
        {
            input.AppendText("Y");
        }

        private void z_Click(object sender, RoutedEventArgs e)
        {
            input.AppendText("Z");
        }


        private void spc_Click(object sender, RoutedEventArgs e)
        {
            input.AppendText(" ");
        }

        private void period_Click(object sender, RoutedEventArgs e)
        {
            input.AppendText(".");
        }
        
        private void comma_Click(object sender, RoutedEventArgs e)
        {
            input.AppendText(",");
        }

        private void question_Click(object sender, RoutedEventArgs e)
        {
            input.AppendText("?");
        }

        private void exclamation_Click(object sender, RoutedEventArgs e)
        {
            input.AppendText("!");
        }

        private void bksp_Click(object sender, RoutedEventArgs e)
        {
            if (input.Text.Length != 0)
                input.Text = input.Text.Remove(input.Text.Length - 1, 1);
        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            if (input.Text.Length != 0)
                input.Text = "";
        }
        private void sym_Click(object sender, RoutedEventArgs e)
        {
            Layout1_Syms keyboard2 = new Layout1_Syms();
            keyboard2.Show();
        }
    }
}
