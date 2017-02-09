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
    /// Interaction logic for Settings.xaml
    /// </summary>
   
    public partial class Settings : Window
    {
        public Settings()
        {
            InitializeComponent();
            apply.IsEnabled = false;
        }

        //**************************************************************************************************************
        //                                  Combo Boxes Load Functions
        //
        //  Description: These events run when the window is loaded and generates the inital values into the dropdowns
        //**************************************************************************************************************

        private void layoutCombo_Loaded(object sender, RoutedEventArgs e)
        {
            List<string> data = new List<string>();

            data.Add("Default");
            data.Add("Future Layout");

            var themeCombo = sender as ComboBox;
            themeCombo.ItemsSource = data;
            themeCombo.SelectedIndex = 0;
        }





        //**************************************************************************************************************
        //                                  Combo Boxes Selection Events
        //
        //  Description: These events run when the option in the box is changed. In this case, overwrite exisiting
        //               settings.settings file. (Don't save until apply is clicked!)
        //**************************************************************************************************************
        private void themeCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)   
        {
            apply.IsEnabled = true;

            int selection = themeCombo.SelectedIndex;

            if (selection == 0)
            {
                this.Background = new SolidColorBrush(Color.FromRgb(28,28,28));
                themeTitle.Foreground = new SolidColorBrush(Color.FromRgb(255,255,255));
                layoutTitle.Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            }
            else
            {
                this.Background = new SolidColorBrush(Color.FromRgb(209, 209, 209));
                themeTitle.Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 0));
                layoutTitle.Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            }
        }

        private void layoutCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }




        //**************************************************************************************************************
        //                                  Three Bottom Buttons
        //
        //  Description: Standard OK, Cancel, and Apply. OK - Close window (if changes made, ask if user wants to apply);
        //               Cancel - Close Window (Don't save); Apply - Don't close window; save changes.
        //**************************************************************************************************************

        
        private void cancel_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void ok_Click(object sender, RoutedEventArgs e)
        {
            Layout1_L keyboard = new Layout1_L();
            keyboard.Show();
            this.Close();
        }

        private void apply_Click(object sender, RoutedEventArgs e)
        {
            apply.IsEnabled = false;
            // SAVE SETTINGS
        }
    }
}
