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
    /// 

    public partial class Layout1_L : Window
    {
        private double x_POS;
        private double y_POS;

        private int[] mouseOverCount = new int[26];

        public Layout1_L(string textbox_string)
        {
            InitializeComponent();

            for(int i = 0; i<25; i++)
            {
                mouseOverCount[i] = 0;
            }

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
                    Settings settings = new Keyboard_Interface.Settings();
                    settings.Show();
                    this.Close();
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
            Array.Clear(mouseOverCount, 0, mouseOverCount.Length);
        }

        private void a_MouseEnter(object sender, MouseEventArgs e)
        {
            if (Properties.Settings.Default.mouseOver == true)
            {
                mouseOverCount[0] += 1;

                if (mouseOverCount[0] == 3)
                {
                    a_Click(sender, e);
                }
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
            Array.Clear(mouseOverCount, 0, mouseOverCount.Length);
        }

        private void b_MouseEnter(object sender, MouseEventArgs e)
        {
            if (Properties.Settings.Default.mouseOver == true)
            {
                mouseOverCount[1] += 1;

                if (mouseOverCount[1] == 3)
                {
                    b_Click(sender, e);
                }
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
            Array.Clear(mouseOverCount, 0, mouseOverCount.Length);
        }

        private void c_MouseEnter(object sender, MouseEventArgs e)
        {
            if (Properties.Settings.Default.mouseOver == true)
            {
                mouseOverCount[2] += 1;

                if (mouseOverCount[2] == 3)
                {
                    c_Click(sender, e);
                }
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
            Array.Clear(mouseOverCount, 0, mouseOverCount.Length);
        }

        private void d_MouseEnter(object sender, MouseEventArgs e)
        {
            if (Properties.Settings.Default.mouseOver == true)
            {
                mouseOverCount[3] += 1;

                if (mouseOverCount[3] == 3)
                {
                    d_Click(sender, e);
                }
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
            Array.Clear(mouseOverCount, 0, mouseOverCount.Length);
        }

        private void e_MouseEnter(object sender, MouseEventArgs e)
        {
            if (Properties.Settings.Default.mouseOver == true)
            {
                mouseOverCount[4] += 1;

                if (mouseOverCount[4] == 3)
                {
                    e_Click(sender, e);
                }
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
            Array.Clear(mouseOverCount, 0, mouseOverCount.Length);
        }

        private void f_MouseEnter(object sender, MouseEventArgs e)
        {
            if (Properties.Settings.Default.mouseOver == true)
            {
                mouseOverCount[5] += 1;

                if (mouseOverCount[5] == 3)
                {
                    f_Click(sender, e);
                }
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
            Array.Clear(mouseOverCount, 0, mouseOverCount.Length);
        }

        private void g_MouseEnter(object sender, MouseEventArgs e)
        {
            if (Properties.Settings.Default.mouseOver == true)
            {
                mouseOverCount[6] += 1;

                if (mouseOverCount[6] == 3)
                {
                    g_Click(sender, e);
                }
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
            Array.Clear(mouseOverCount, 0, mouseOverCount.Length);
        }

        private void h_MouseEnter(object sender, MouseEventArgs e)
        {
            if (Properties.Settings.Default.mouseOver == true)
            {
                mouseOverCount[7] += 1;

                if (mouseOverCount[7] == 3)
                {
                    h_Click(sender, e);
                }
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
            Array.Clear(mouseOverCount, 0, mouseOverCount.Length);
        }

        private void i_MouseEnter(object sender, MouseEventArgs e)
        {
            if (Properties.Settings.Default.mouseOver == true)
            {
                mouseOverCount[8] += 1;

                if (mouseOverCount[8] == 3)
                {
                    i_Click(sender, e);
                }
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
            Array.Clear(mouseOverCount, 0, mouseOverCount.Length);
        }

        private void j_MouseEnter(object sender, MouseEventArgs e)
        {
            if (Properties.Settings.Default.mouseOver == true)
            {
                mouseOverCount[9] += 1;

                if (mouseOverCount[9] == 3)
                {
                    j_Click(sender, e);
                }
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
            Array.Clear(mouseOverCount, 0, mouseOverCount.Length);
        }

        private void k_MouseEnter(object sender, MouseEventArgs e)
        {
            if (Properties.Settings.Default.mouseOver == true)
            {
                mouseOverCount[10] += 1;

                if (mouseOverCount[10] == 3)
                {
                    k_Click(sender, e);
                }
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
            Array.Clear(mouseOverCount, 0, mouseOverCount.Length);
        }

        private void l_MouseEnter(object sender, MouseEventArgs e)
        {
            if (Properties.Settings.Default.mouseOver == true)
            {
                mouseOverCount[11] += 1;

                if (mouseOverCount[11] == 3)
                {
                    l_Click(sender, e);
                }
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
            Array.Clear(mouseOverCount, 0, mouseOverCount.Length);
        }

        private void m_MouseEnter(object sender, MouseEventArgs e)
        {
            if (Properties.Settings.Default.mouseOver == true)
            {
                mouseOverCount[12] += 1;

                if (mouseOverCount[12] == 3)
                {
                    m_Click(sender, e);
                }
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
            Array.Clear(mouseOverCount, 0, mouseOverCount.Length);
        }

        private void n_MouseEnter(object sender, MouseEventArgs e)
        {
            if (Properties.Settings.Default.mouseOver == true)
            {
                mouseOverCount[13] += 1;

                if (mouseOverCount[13] == 3)
                {
                    n_Click(sender, e);
                }
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
            Array.Clear(mouseOverCount, 0, mouseOverCount.Length);
        }

        private void o_MouseEnter(object sender, MouseEventArgs e)
        {
            if (Properties.Settings.Default.mouseOver == true)
            {
                mouseOverCount[14] += 1;

                if (mouseOverCount[14] == 3)
                {
                    o_Click(sender, e);
                }
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
            Array.Clear(mouseOverCount, 0, mouseOverCount.Length);
        }

        private void p_MouseEnter(object sender, MouseEventArgs e)
        {
            if (Properties.Settings.Default.mouseOver == true)
            {
                mouseOverCount[15] += 1;

                if (mouseOverCount[15] == 3)
                {
                    p_Click(sender, e);
                }
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
            Array.Clear(mouseOverCount, 0, mouseOverCount.Length);
        }

        private void q_MouseEnter(object sender, MouseEventArgs e)
        {
            if (Properties.Settings.Default.mouseOver == true)
            {
                mouseOverCount[16] += 1;

                if (mouseOverCount[16] == 3)
                {
                    q_Click(sender, e);
                }
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
            Array.Clear(mouseOverCount, 0, mouseOverCount.Length);
        }

        private void r_MouseEnter(object sender, MouseEventArgs e)
        {
            if (Properties.Settings.Default.mouseOver == true)
            {
                mouseOverCount[17] += 1;

                if (mouseOverCount[17] == 3)
                {
                    r_Click(sender, e);
                }
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
            Array.Clear(mouseOverCount, 0, mouseOverCount.Length);
        }

        private void s_MouseEnter(object sender, MouseEventArgs e)
        {
            if (Properties.Settings.Default.mouseOver == true)
            {
                mouseOverCount[18] += 1;

                if (mouseOverCount[18] == 3)
                {
                    s_Click(sender, e);
                }
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
            Array.Clear(mouseOverCount, 0, mouseOverCount.Length);
        }

        private void t_MouseEnter(object sender, MouseEventArgs e)
        {
            if (Properties.Settings.Default.mouseOver == true)
            {
                mouseOverCount[19] += 1;

                if (mouseOverCount[19] == 3)
                {
                    t_Click(sender, e);
                }
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
            Array.Clear(mouseOverCount, 0, mouseOverCount.Length);
        }

        private void u_MouseEnter(object sender, MouseEventArgs e)
        {
            if (Properties.Settings.Default.mouseOver == true)
            {
                mouseOverCount[20] += 1;

                if (mouseOverCount[20] == 3)
                {
                    u_Click(sender, e);
                }
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
            Array.Clear(mouseOverCount, 0, mouseOverCount.Length);
        }

        private void v_MouseEnter(object sender, MouseEventArgs e)
        {
            if (Properties.Settings.Default.mouseOver == true)
            {
                mouseOverCount[21] += 1;

                if (mouseOverCount[21] == 3)
                {
                    v_Click(sender, e);
                }
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
            Array.Clear(mouseOverCount, 0, mouseOverCount.Length);
        }

        private void w_MouseEnter(object sender, MouseEventArgs e)
        {
            if (Properties.Settings.Default.mouseOver == true)
            {
                mouseOverCount[22] += 1;

                if (mouseOverCount[22] == 3)
                {
                    w_Click(sender, e);
                }
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
            Array.Clear(mouseOverCount, 0, mouseOverCount.Length);
        }

        private void x_MouseEnter(object sender, MouseEventArgs e)
        {
            if (Properties.Settings.Default.mouseOver == true)
            {
                mouseOverCount[23] += 1;

                if (mouseOverCount[23] == 3)
                {
                    x_Click(sender, e);
                }
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
            Array.Clear(mouseOverCount, 0, mouseOverCount.Length);
        }

        private void y_MouseEnter(object sender, MouseEventArgs e)
        {
            if (Properties.Settings.Default.mouseOver == true)
            {
                mouseOverCount[24] += 1;

                if (mouseOverCount[24] == 3)
                {
                    y_Click(sender, e);
                }
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
            Array.Clear(mouseOverCount, 0, mouseOverCount.Length);
        }

        private void z_MouseEnter(object sender, MouseEventArgs e)
        {
            if (Properties.Settings.Default.mouseOver == true)
            {
                mouseOverCount[25] += 1;

                if (mouseOverCount[25] == 3)
                {
                    z_Click(sender, e);
                }
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
            if (Properties.Settings.Default.DEVMODE == true && input.Text.Length != 0)
            {
                string str = input.Text;
                int length = str.Length;
                char removedChar = str[length - 1];
                MistakeModule(input.Text, removedChar);
            }

            if (input.Text.Length > 1)
                input.Text = input.Text.Remove(input.Text.Length - 1, 1);

            else if (input.Text.Length == 1)
            {
                input.Text = input.Text.Remove(input.Text.Length - 1, 1);
                Properties.Settings.Default.CAPs = true;
                upperCase();
            }

        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult clear_result = MessageBox.Show("Clear Text?", "Clear?", MessageBoxButton.YesNo);
            switch (clear_result)
            {
                case MessageBoxResult.Yes:
                    if (input.Text.Length != 0)
                    {
                        input.Text = "";
                        upperCase();
                        Properties.Settings.Default.CAPs = true;
                    }
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

        private void InputtoFile(string str)
        {
                String filename = "C:\\Keyboard_Interface_Test_Data\\mistakes.txt";
                FileStream fs = new FileStream(filename, FileMode.Append, FileAccess.Write);
                StreamWriter objWrite = new StreamWriter(fs);
                objWrite.Write(str);
                objWrite.Close();
        }

        private void MistakeModule(string currentText, char removedChar)
        {
            String output;
            String dt = DateTime.Now.ToString("yyyy-MM-dd  hh:mm:ss");
            String spacing = "                      ";


            output = dt + spacing + currentText + spacing + removedChar + "\r\n";
            InputtoFile(output);
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (Properties.Settings.Default.DEVMODE == true)
            {
                Point p = e.GetPosition(this);

                x_POS = p.X;
                y_POS = p.Y;

                String x_POS1 = x_POS.ToString();
                String y_POS1 = y_POS.ToString();

                String filename = "C:\\Keyboard_Interface_Test_Data\\coords.txt";
                FileStream fs = new FileStream(filename, FileMode.Append, FileAccess.Write);
                StreamWriter objWrite = new StreamWriter(fs);

                objWrite.Write(x_POS1);
                objWrite.Write("               ");
                objWrite.Write(y_POS1 + "\r\n");
                objWrite.Close();
            }
        }


    }
}