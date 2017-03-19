using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Speech.Synthesis;

namespace Keyboard_Interface
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>


    public partial class Layout2 : Window
    {
        public Layout2(string textbox_string)
        {
            InitializeComponent();

            //Stream cursorStream = Application.GetResourceStream(new Uri("pack://application:,,,/blue_curs1.cur")).Stream;
            // this.Cursor = new Cursor(cursorStream);

            StreamResourceInfo sri = Application.GetResourceStream(new Uri("blue_curs1.cur", UriKind.Relative));
            Cursor customCursor = new Cursor(sri.Stream);
            Mouse.OverrideCursor = customCursor;

            input.Text = textbox_string;
            this.Background = new SolidColorBrush(Color.FromRgb(Properties.Settings.Default.themeRGB, Properties.Settings.Default.themeRGB, Properties.Settings.Default.themeRGB));
            disableAll.Background = new SolidColorBrush(Color.FromRgb(Properties.Settings.Default.themeRGB, Properties.Settings.Default.themeRGB, Properties.Settings.Default.themeRGB));
        }

        private void close_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult close_result = MessageBox.Show("Close Application?", "Close?", MessageBoxButton.YesNoCancel);
            switch (close_result)
            {
                case MessageBoxResult.Yes:
                    Application.Current.Shutdown();
                    break;
                case MessageBoxResult.No:
                    break;
                case MessageBoxResult.Cancel:
                    break;
            }
        }

        private void a_Click(object sender, RoutedEventArgs e)
        {
            if (Properties.Settings.Default.CAPs == true && Properties.Settings.Default.CAPsKey == false)
            {
                input.AppendText("A");
                lowerCase();
                Properties.Settings.Default.CAPs = false;
            }

            else if (Properties.Settings.Default.CAPs == true && Properties.Settings.Default.CAPsKey == true)
            {
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
            MessageBoxResult clear_result = MessageBox.Show("Clear Text?", "Clear?", MessageBoxButton.YesNo);
            switch (clear_result)
            {
                case MessageBoxResult.Yes:
                    if (input.Text.Length != 0)
                        input.Text = "";
                    break;
                case MessageBoxResult.No:
                    break;
            };
        }
        private void sym_Click(object sender, RoutedEventArgs e)
        {
            string textbox_string = input.Text;
            Layout1_Syms keyboard2 = new Layout1_Syms(textbox_string);
            keyboard2.Show();
            this.Close();
        }
        private void caps_Click(object sender, RoutedEventArgs e)
        {
            if (Properties.Settings.Default.CAPs == false)
            {
                caps.Style = (Style)Application.Current.Resources["sym_capsButtonTemplate_ON"];
                upperCase();
                Properties.Settings.Default.CAPsKey = true;
                Properties.Settings.Default.CAPs = true;
            }
            else
            {
                caps.Style = (Style)Application.Current.Resources["sym_capsButtonTemplate"];
                lowerCase();
                Properties.Settings.Default.CAPsKey = true;
                Properties.Settings.Default.CAPs = false;
            }
        }

        private void voice_Click(object sender, RoutedEventArgs e)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.SetOutputToDefaultAudioDevice();
            synth.Speak(input.Text);
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

        private void disableALL(object sender, RoutedEventArgs ee)
        {
            if (Properties.Settings.Default.paused == false)
            {
                Properties.Settings.Default.paused = true;
                disableAll.Background = new SolidColorBrush(Color.FromRgb(230, 0, 0));
                a.IsEnabled = false;
                b.IsEnabled = false;
                c.IsEnabled = false;
                d.IsEnabled = false;
                e.IsEnabled = false;
                f.IsEnabled = false;
                g.IsEnabled = false;
                h.IsEnabled = false;
                i.IsEnabled = false;
                j.IsEnabled = false;
                k.IsEnabled = false;
                l.IsEnabled = false;
                m.IsEnabled = false;
                n.IsEnabled = false;
                o.IsEnabled = false;
                p.IsEnabled = false;
                q.IsEnabled = false;
                r.IsEnabled = false;
                s.IsEnabled = false;
                t.IsEnabled = false;
                u.IsEnabled = false;
                v.IsEnabled = false;
                w.IsEnabled = false;
                x.IsEnabled = false;
                y.IsEnabled = false;
                z.IsEnabled = false;
                space.IsEnabled = false;
                clear.IsEnabled = false;
                close.IsEnabled = false;
                period.IsEnabled = false;
                comma.IsEnabled = false;
                ex.IsEnabled = false;
                question.IsEnabled = false;
                bksp.IsEnabled = false;
                bksp1.IsEnabled = false;
                caps.IsEnabled = false;
                sym.IsEnabled = false;

            }
            else
            {
                Properties.Settings.Default.paused = false;
                disableAll.Background = new SolidColorBrush(Color.FromRgb(Properties.Settings.Default.themeRGB, Properties.Settings.Default.themeRGB, Properties.Settings.Default.themeRGB));
                a.IsEnabled = true;
                b.IsEnabled = true;
                c.IsEnabled = true;
                d.IsEnabled = true;
                e.IsEnabled = true;
                f.IsEnabled = true;
                g.IsEnabled = true;
                h.IsEnabled = true;
                i.IsEnabled = true;
                j.IsEnabled = true;
                k.IsEnabled = true;
                l.IsEnabled = true;
                m.IsEnabled = true;
                n.IsEnabled = true;
                o.IsEnabled = true;
                p.IsEnabled = true;
                q.IsEnabled = true;
                r.IsEnabled = true;
                s.IsEnabled = true;
                t.IsEnabled = true;
                u.IsEnabled = true;
                v.IsEnabled = true;
                w.IsEnabled = true;
                x.IsEnabled = true;
                y.IsEnabled = true;
                z.IsEnabled = true;
                space.IsEnabled = true;
                clear.IsEnabled = true;
                close.IsEnabled = true;
                period.IsEnabled = true;
                comma.IsEnabled = true;
                ex.IsEnabled = true;
                question.IsEnabled = true;
                bksp.IsEnabled = true;
                bksp1.IsEnabled = true;
                caps.IsEnabled = true;
                sym.IsEnabled = true;
            }
        }
    }
}

