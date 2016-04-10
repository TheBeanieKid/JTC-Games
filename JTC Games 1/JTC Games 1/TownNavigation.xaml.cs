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

namespace JTC_Games_1
{
    /// <summary>
    /// Interaction logic for TownNavigation.xaml
    /// </summary>
    public partial class TownNavigation : Window
    {

        public static int number = 4;

        public TownNavigation()
        {
            InitializeComponent();

            // Move it anywhere you want lol
            // This is how you can pass fields from other classes...
            _1.Text = "" + MainGameWindow.currentStone;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(MainGameWindow))
                {                    
                    this.Hide();
                    (window as MainGameWindow).Show();
                }
            }           
        }
    }
}
