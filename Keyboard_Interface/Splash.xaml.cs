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
using System.Windows.Threading;

namespace Keyboard_Interface
{
    /// <summary>
    /// Interaction logic for Splash.xaml
    /// </summary>
    public partial class Splash : Window
    {
        DispatcherTimer splashTime = new DispatcherTimer();

        public Splash()
        {
            InitializeComponent();

            splashTime.Tick += new EventHandler(splashTime_tick);
            splashTime.Interval = new TimeSpan(0, 0, 2);        // CHANGE BACK to 6
            splashTime.Start();
        }

        private void splashTime_tick(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.firstRun)
            {
                /* UNCOMMENT UPON COMPLETION OF SETTINGS
                Settings set = new Settings();
                set.Show();
                */
                splashTime.Stop();
                this.Hide();
                //Properties.Settings.Default.firstRun = false;
            }
            else
            {
                /* UNCOMMENT UPON COMPLETION OF SETTINGS
                Layout1_L win = new Layout1_L("");
                win.Show();
                */
                Settings set = new Settings();
                set.Show();
                splashTime.Stop();
                this.Hide();
            }
        }
    }
}
