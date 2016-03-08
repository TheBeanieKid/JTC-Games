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
    /// Interaction logic for MainGameWindow.xaml
    /// </summary>
    public partial class MainGameWindow : Window
    {

        public MainGameWindow()
        {
            InitializeComponent();

            LumberCampDetails.Text = " Details :\n\n Bulid Cost :   40 Wood\n\n Production/s :   1";
            LumberCampDetails.Visibility = Visibility.Collapsed;
        }

        private void LumberCamp_MouseEnter(object sender, MouseEventArgs e)
        {
            LumberCampDetails.Visibility = Visibility.Visible;
        }

        private void LumberCamp_MouseLeave(object sender, MouseEventArgs e)
        {
            LumberCampDetails.Visibility = Visibility.Collapsed;
        }

        private void LumberCamp_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Rectangle_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Rect_1.Fill = new SolidColorBrush(Colors.Red);
        }
    }
}
