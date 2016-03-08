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

namespace JTC_Games_1
{
    /// <summary>
    /// Interaction logic for MainGameWindow.xaml
    /// </summary>
    public partial class MainGameWindow : Window
    {
        //Make a new timer to update every so, 1 tenth of a sec?
        DispatcherTimer t = new DispatcherTimer();
        public MainGameWindow()
        {
            InitializeComponent();
            t.Interval = new TimeSpan(0,0,0,0,1);
            t.Tick += new EventHandler(timersTick);
            t.Start();
            LumberCampDetails.Text = " Details :\n\n Bulid Cost :   40 Wood\n\n Production/s :   1";
            LumberCampDetails.Visibility = Visibility.Collapsed;
        }

        //Will do this method every 1 millisecond lol 
        private void timersTick(object sender, EventArgs e)
        {
            //gets mouse's position, then u can check for its X pos by doing point.X, so on
            var point = Mouse.GetPosition(this);
            //So the mouse is in the middle of the rectangle when it follows V
            Canvas.SetTop(LumberCamp, point.Y - (LumberCamp.Height / 2));
            Canvas.SetLeft(LumberCamp, point.X - (LumberCamp.Width / 2));

            //For rectangle collisions, you need to make a clone but make it a 'rect'
            Rect rectPlayersObject = new Rect(Canvas.GetLeft(LumberCamp), Canvas.GetTop(LumberCamp), LumberCamp.Width, LumberCamp.Height);
            //Whatever has to be a rect so do this instead change LumberCamp to Whatever or so what ^
            if (rectPlayersObject.IntersectsWith(Whatever) == true)
            {
                //It'll do whatever if the rectangle intersects with Whatever
            }
            //For mouse collisions
            if (Mouse.DirectlyOver == LumberCamp)
            {
                //If mouse is hovering over the LumberCamp then do shit in here
            }
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

        }
    }
}
