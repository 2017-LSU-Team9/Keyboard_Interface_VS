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
            if(Properties.Settings.Default.CAPs == true && Properties.Settings.Default.CAPsKey == false){
                input.AppendText("A");
                lowerCase();
                Properties.Settings.Default.CAPs = false;
            }

            else if(Properties.Settings.Default.CAPs == true && Properties.Settings.Default.CAPsKey == true){
                input.AppendText("A");
            }

            else
            {
               input.AppendText("a");
            }
        }

        private void b_Click(object sender, RoutedEventArgs e)
        {
            if (Properties.Settings.Default.CAPs == true && Properties.Settings.Default.CAPsKey == false)
            {
                input.AppendText("B");
                lowerCase();
                Properties.Settings.Default.CAPs = false;
            }

            else if (Properties.Settings.Default.CAPs == true && Properties.Settings.Default.CAPsKey == true)
            {
                input.AppendText("B");
            }

            else
            {
                input.AppendText("b");
            }
        }

        private void c_Click(object sender, RoutedEventArgs e)
        {
            if (Properties.Settings.Default.CAPs == true && Properties.Settings.Default.CAPsKey == false)
            {
                input.AppendText("C");
                lowerCase();
                Properties.Settings.Default.CAPs = false;
            }

            else if (Properties.Settings.Default.CAPs == true && Properties.Settings.Default.CAPsKey == true)
            {
                input.AppendText("C");
            }

            else
            {
                input.AppendText("c");
            }
        }

        private void d_Click(object sender, RoutedEventArgs e)
        {
            if (Properties.Settings.Default.CAPs == true && Properties.Settings.Default.CAPsKey == false)
            {
                input.AppendText("D");
                lowerCase();
                Properties.Settings.Default.CAPs = false;
            }

            else if (Properties.Settings.Default.CAPs == true && Properties.Settings.Default.CAPsKey == true)
            {
                input.AppendText("D");
            }

            else
            {
                input.AppendText("d");
            }
        }

        private void e_Click(object sender, RoutedEventArgs e)
        {
            if (Properties.Settings.Default.CAPs == true && Properties.Settings.Default.CAPsKey == false)
            {
                input.AppendText("E");
                lowerCase();
                Properties.Settings.Default.CAPs = false;
            }

            else if (Properties.Settings.Default.CAPs == true && Properties.Settings.Default.CAPsKey == true)
            {
                input.AppendText("E");
            }

            else
            {
                input.AppendText("e");
            }
        }

        private void f_Click(object sender, RoutedEventArgs e)
        {
            if (Properties.Settings.Default.CAPs == true && Properties.Settings.Default.CAPsKey == false)
            {
                input.AppendText("F");
                lowerCase();
                Properties.Settings.Default.CAPs = false;
            }

            else if (Properties.Settings.Default.CAPs == true && Properties.Settings.Default.CAPsKey == true)
            {
                input.AppendText("F");
            }

            else
            {
                input.AppendText("f");
            }
        }

        private void g_Click(object sender, RoutedEventArgs e)
        {
            if (Properties.Settings.Default.CAPs == true && Properties.Settings.Default.CAPsKey == false)
            {
                input.AppendText("G");
                lowerCase();
                Properties.Settings.Default.CAPs = false;
            }

            else if (Properties.Settings.Default.CAPs == true && Properties.Settings.Default.CAPsKey == true)
            {
                input.AppendText("G");
            }

            else
            {
                input.AppendText("g");
            }
        }

        private void h_Click(object sender, RoutedEventArgs e)
        {
            if (Properties.Settings.Default.CAPs == true && Properties.Settings.Default.CAPsKey == false)
            {
                input.AppendText("H");
                lowerCase();
                Properties.Settings.Default.CAPs = false;
            }

            else if (Properties.Settings.Default.CAPs == true && Properties.Settings.Default.CAPsKey == true)
            {
                input.AppendText("H");
            }

            else
            {
                input.AppendText("h");
            }
        }

        private void i_Click(object sender, RoutedEventArgs e)
        {
            if (Properties.Settings.Default.CAPs == true && Properties.Settings.Default.CAPsKey == false)
            {
                input.AppendText("I");
                lowerCase();
                Properties.Settings.Default.CAPs = false;
            }

            else if (Properties.Settings.Default.CAPs == true && Properties.Settings.Default.CAPsKey == true)
            {
                input.AppendText("I");
            }

            else
            {
                input.AppendText("i");
            }
        }

        private void j_Click(object sender, RoutedEventArgs e)
        {
            if (Properties.Settings.Default.CAPs == true && Properties.Settings.Default.CAPsKey == false)
            {
                input.AppendText("J");
                lowerCase();
                Properties.Settings.Default.CAPs = false;
            }

            else if (Properties.Settings.Default.CAPs == true && Properties.Settings.Default.CAPsKey == true)
            {
                input.AppendText("J");
            }

            else
            {
                input.AppendText("j");
            }
        }

        private void k_Click(object sender, RoutedEventArgs e)
        {
            if (Properties.Settings.Default.CAPs == true && Properties.Settings.Default.CAPsKey == false)
            {
                input.AppendText("K");
                lowerCase();
                Properties.Settings.Default.CAPs = false;
            }

            else if (Properties.Settings.Default.CAPs == true && Properties.Settings.Default.CAPsKey == true)
            {
                input.AppendText("K");
            }

            else
            {
                input.AppendText("k");
            }
        }

        private void l_Click(object sender, RoutedEventArgs e)
        {
            if (Properties.Settings.Default.CAPs == true && Properties.Settings.Default.CAPsKey == false)
            {
                input.AppendText("L");
                lowerCase();
                Properties.Settings.Default.CAPs = false;
            }

            else if (Properties.Settings.Default.CAPs == true && Properties.Settings.Default.CAPsKey == true)
            {
                input.AppendText("L");
            }

            else
            {
                input.AppendText("l");
            }
        }

        private void m_Click(object sender, RoutedEventArgs e)
        {
            if (Properties.Settings.Default.CAPs == true && Properties.Settings.Default.CAPsKey == false)
            {
                input.AppendText("M");
                lowerCase();
                Properties.Settings.Default.CAPs = false;
            }

            else if (Properties.Settings.Default.CAPs == true && Properties.Settings.Default.CAPsKey == true)
            {
                input.AppendText("M");
            }

            else
            {
                input.AppendText("m");
            }
        }

        private void n_Click(object sender, RoutedEventArgs e)
        {
            if (Properties.Settings.Default.CAPs == true && Properties.Settings.Default.CAPsKey == false)
            {
                input.AppendText("N");
                lowerCase();
                Properties.Settings.Default.CAPs = false;
            }

            else if (Properties.Settings.Default.CAPs == true && Properties.Settings.Default.CAPsKey == true)
            {
                input.AppendText("N");
            }

            else
            {
                input.AppendText("n");
            }
        }

        private void o_Click(object sender, RoutedEventArgs e)
        {
            if (Properties.Settings.Default.CAPs == true && Properties.Settings.Default.CAPsKey == false)
            {
                input.AppendText("O");
                lowerCase();
                Properties.Settings.Default.CAPs = false;
            }

            else if (Properties.Settings.Default.CAPs == true && Properties.Settings.Default.CAPsKey == true)
            {
                input.AppendText("O");
            }

            else
            {
                input.AppendText("o");
            }
        }

        private void p_Click(object sender, RoutedEventArgs e)
        {
            if (Properties.Settings.Default.CAPs == true && Properties.Settings.Default.CAPsKey == false)
            {
                input.AppendText("P");
                lowerCase();
                Properties.Settings.Default.CAPs = false;
            }

            else if (Properties.Settings.Default.CAPs == true && Properties.Settings.Default.CAPsKey == true)
            {
                input.AppendText("P");
            }

            else
            {
                input.AppendText("p");
            }
        }

        private void q_Click(object sender, RoutedEventArgs e)
        {
            if (Properties.Settings.Default.CAPs == true && Properties.Settings.Default.CAPsKey == false)
            {
                input.AppendText("Q");
                lowerCase();
                Properties.Settings.Default.CAPs = false;
            }

            else if (Properties.Settings.Default.CAPs == true && Properties.Settings.Default.CAPsKey == true)
            {
                input.AppendText("Q");
            }

            else
            {
                input.AppendText("q");
            }
        }

        private void r_Click(object sender, RoutedEventArgs e)
        {
            if (Properties.Settings.Default.CAPs == true && Properties.Settings.Default.CAPsKey == false)
            {
                input.AppendText("R");
                lowerCase();
                Properties.Settings.Default.CAPs = false;
            }

            else if (Properties.Settings.Default.CAPs == true && Properties.Settings.Default.CAPsKey == true)
            {
                input.AppendText("R");
            }

            else
            {
                input.AppendText("r");
            }
        }

        private void s_Click(object sender, RoutedEventArgs e)
        {
            if (Properties.Settings.Default.CAPs == true && Properties.Settings.Default.CAPsKey == false)
            {
                input.AppendText("S");
                lowerCase();
                Properties.Settings.Default.CAPs = false;
            }

            else if (Properties.Settings.Default.CAPs == true && Properties.Settings.Default.CAPsKey == true)
            {
                input.AppendText("S");
            }

            else
            {
                input.AppendText("s");
            }
        }

        private void t_Click(object sender, RoutedEventArgs e)
        {
            if (Properties.Settings.Default.CAPs == true && Properties.Settings.Default.CAPsKey == false)
            {
                input.AppendText("T");
                lowerCase();
                Properties.Settings.Default.CAPs = false;
            }

            else if (Properties.Settings.Default.CAPs == true && Properties.Settings.Default.CAPsKey == true)
            {
                input.AppendText("T");
            }

            else
            {
                input.AppendText("t");
            }
        }

        private void u_Click(object sender, RoutedEventArgs e)
        {
            if (Properties.Settings.Default.CAPs == true && Properties.Settings.Default.CAPsKey == false)
            {
                input.AppendText("U");
                lowerCase();
                Properties.Settings.Default.CAPs = false;
            }

            else if (Properties.Settings.Default.CAPs == true && Properties.Settings.Default.CAPsKey == true)
            {
                input.AppendText("U");
            }

            else
            {
                input.AppendText("u");
            }
        }

        private void v_Click(object sender, RoutedEventArgs e)
        {
            if (Properties.Settings.Default.CAPs == true && Properties.Settings.Default.CAPsKey == false)
            {
                input.AppendText("V");
                lowerCase();
                Properties.Settings.Default.CAPs = false;
            }

            else if (Properties.Settings.Default.CAPs == true && Properties.Settings.Default.CAPsKey == true)
            {
                input.AppendText("V");
            }

            else
            {
                input.AppendText("v");
            }
        }

        private void w_Click(object sender, RoutedEventArgs e)
        {
            if (Properties.Settings.Default.CAPs == true && Properties.Settings.Default.CAPsKey == false)
            {
                input.AppendText("W");
                lowerCase();
                Properties.Settings.Default.CAPs = false;
            }

            else if (Properties.Settings.Default.CAPs == true && Properties.Settings.Default.CAPsKey == true)
            {
                input.AppendText("W");
            }

            else
            {
                input.AppendText("w");
            }
        }

        private void x_Click(object sender, RoutedEventArgs e)
        {
            if (Properties.Settings.Default.CAPs == true && Properties.Settings.Default.CAPsKey == false)
            {
                input.AppendText("X");
                lowerCase();
                Properties.Settings.Default.CAPs = false;
            }

            else if (Properties.Settings.Default.CAPs == true && Properties.Settings.Default.CAPsKey == true)
            {
                input.AppendText("X");
            }

            else
            {
                input.AppendText("x");
            }
        }

        private void y_Click(object sender, RoutedEventArgs e)
        {
            if (Properties.Settings.Default.CAPs == true && Properties.Settings.Default.CAPsKey == false)
            {
                input.AppendText("Y");
                lowerCase();
                Properties.Settings.Default.CAPs = false;
            }

            else if (Properties.Settings.Default.CAPs == true && Properties.Settings.Default.CAPsKey == true)
            {
                input.AppendText("Y");
            }

            else
            {
                input.AppendText("y");
            }
        }

        private void z_Click(object sender, RoutedEventArgs e)
        {
            if (Properties.Settings.Default.CAPs == true && Properties.Settings.Default.CAPsKey == false)
            {
                input.AppendText("Z");
                lowerCase();
                Properties.Settings.Default.CAPs = false;
            }

            else if (Properties.Settings.Default.CAPs == true && Properties.Settings.Default.CAPsKey == true)
            {
                input.AppendText("Z");
            }

            else
            {
                input.AppendText("z");
            }
        }


        private void spc_Click(object sender, RoutedEventArgs e)
        {
            input.AppendText(" ");
        }

        private void period_Click(object sender, RoutedEventArgs e)
        {
            input.AppendText(".");
            input.AppendText(" ");
            upperCase();
            Properties.Settings.Default.CAPs = true;
            Properties.Settings.Default.CAPsKey = false;
        }
        
        private void comma_Click(object sender, RoutedEventArgs e)
        {
            input.AppendText(",");
        }

        private void question_Click(object sender, RoutedEventArgs e)
        {
            input.AppendText("?");
            input.AppendText(" ");
            upperCase();
            Properties.Settings.Default.CAPs = true;
            Properties.Settings.Default.CAPsKey = false;
        }

        private void exclamation_Click(object sender, RoutedEventArgs e)
        {
            input.AppendText("!");
            input.AppendText(" ");
            upperCase();
            Properties.Settings.Default.CAPs = true;
            Properties.Settings.Default.CAPsKey = false;
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
        private void caps_Click(object sender, RoutedEventArgs e)
        {
            if (Properties.Settings.Default.CAPs == false)
            {
                upperCase();
                Properties.Settings.Default.CAPsKey = true;
                Properties.Settings.Default.CAPs = true;
            }
            else
            {
                lowerCase();
                Properties.Settings.Default.CAPsKey = true;
                Properties.Settings.Default.CAPs = false;
            }
        }

        private void lowerCase()
        {
            a.Content = "a";
            b.Content = "b";
            c.Content = "c";
            d.Content = "d";
            e.Content = "e";
            f.Content = "f";
            g.Content = "g";
            h.Content = "h";
            i.Content = "i";
            j.Content = "j";
            k.Content = "k";
            l.Content = "l";
            m.Content = "m";
            n.Content = "n";
            o.Content = "o";
            p.Content = "p";
            q.Content = "q";
            r.Content = "r";
            s.Content = "s";
            t.Content = "t";
            u.Content = "u";
            v.Content = "v";
            w.Content = "w";
            x.Content = "x";
            y.Content = "y";
            z.Content = "z";
        }

        private void upperCase()
        {
            a.Content = "A";
            b.Content = "B";
            c.Content = "C";
            d.Content = "D";
            e.Content = "E";
            f.Content = "F";
            g.Content = "G";
            h.Content = "H";
            i.Content = "I";
            j.Content = "J";
            k.Content = "K";
            l.Content = "L";
            m.Content = "M";
            n.Content = "N";
            o.Content = "O";
            p.Content = "P";
            q.Content = "Q";
            r.Content = "R";
            s.Content = "S";
            t.Content = "T";
            u.Content = "U";
            v.Content = "V";
            w.Content = "W";
            x.Content = "X";
            y.Content = "Y";
            z.Content = "Z";
        }
    }
}
