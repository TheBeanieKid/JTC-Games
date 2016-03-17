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
    public partial class MainGameWindow : Window
    {

        public static bool _1Selected = false;
        public static bool _2Selected = false;
        public static bool _3Selected = false;
        public static bool _4Selected = false;
        public static bool _5Selected = false;
        public static bool _6Selected = false;
        public static bool _7Selected = false;
        public static bool _8Selected = false;
        public static bool _9Selected = false;
        public static bool _10Selected = false;
        public static bool _11Selected = false;
        public static bool _12Selected = false;

        public static int NumberOfLumberCamps = 0;
        public static int currentLumber = 100;

        public static int NumberOfStoneCamps = 0;
        public static int currentStone = 25;

        public MainGameWindow()
        {
            InitializeComponent();


            #region Lumber Timer  250/ms

            System.Windows.Threading.DispatcherTimer LumberTimer = new System.Windows.Threading.DispatcherTimer();
            LumberTimer.Tick += new EventHandler(LumberTimer_Tick);
            LumberTimer.Interval = new TimeSpan(0, 0, 0, 0, 250);
            LumberTimer.Start();

            #endregion

            #region Stone Timer  800/ms

            System.Windows.Threading.DispatcherTimer StoneTimer = new System.Windows.Threading.DispatcherTimer();
            StoneTimer.Tick += new EventHandler(StoneTimer_Tick);
            StoneTimer.Interval = new TimeSpan(0, 0, 0, 0, 800);
            StoneTimer.Start();

            #endregion


            BuildHidden();
            blackText.Text = " Select a place to build";

            CurrentLumberCount.Text = "" + currentLumber;
            CurrentStoneCount.Text = "" + currentStone;
        }

        private void LumberTimer_Tick(object sender, EventArgs e)
        {
            if (NumberOfLumberCamps >= 1)
            {                
                currentLumber = currentLumber + NumberOfLumberCamps;
                CurrentLumberCount.Text = "" + currentLumber;
            }
            else
            {
                
            }
        }

        private void StoneTimer_Tick(object sender, EventArgs e)
        {
            if (NumberOfStoneCamps >= 1)
            {
                currentStone = currentStone + NumberOfStoneCamps;
                CurrentStoneCount.Text = "" + currentStone;
            }
        }

        private void BuildVisible ()
        {
            blackText.Visibility = Visibility.Visible;
            Build_1.Visibility = Visibility.Visible;
            Build_2.Visibility = Visibility.Visible;
            Build_3.Visibility = Visibility.Visible;
            Build_4.Visibility = Visibility.Visible;
            Build_5.Visibility = Visibility.Visible;
            Build_6.Visibility = Visibility.Visible;
            Build_7.Visibility = Visibility.Visible;
            Build_8.Visibility = Visibility.Visible;
            Build_9.Visibility = Visibility.Visible;
            Build_10.Visibility = Visibility.Visible;
            Build_11.Visibility = Visibility.Visible;
            Build_12.Visibility = Visibility.Visible;
        }
        private void BuildHidden()
        {
            Build_1.Visibility = Visibility.Collapsed;
            Build_2.Visibility = Visibility.Collapsed;
            Build_3.Visibility = Visibility.Collapsed;
            Build_4.Visibility = Visibility.Collapsed;
            Build_5.Visibility = Visibility.Collapsed;
            Build_6.Visibility = Visibility.Collapsed;
            Build_7.Visibility = Visibility.Collapsed;
            Build_8.Visibility = Visibility.Collapsed;
            Build_9.Visibility = Visibility.Collapsed;
            Build_10.Visibility = Visibility.Collapsed;
            Build_11.Visibility = Visibility.Collapsed;
            Build_12.Visibility = Visibility.Collapsed;
        }

        private void Canvas_MouseDown(object sender, MouseButtonEventArgs e)
        {
            BuildHidden();
            blackText.Text = " Select a place to build";
            SelectedAllFalse();
        }
        private void Rectangle_MouseDown(object sender, MouseButtonEventArgs e)
        {
            BuildHidden();
            blackText.Text = " Select a place to build";
            SelectedAllFalse();
        }

        private void SelectedFalse (bool currentSelected)
        {
        _1Selected = false;
        _2Selected = false;
        _3Selected = false;
        _4Selected = false;
        _5Selected = false;
        _6Selected = false;
        _7Selected = false;
        _8Selected = false;
        _9Selected = false;
        _10Selected = false;
        _11Selected = false;
        _12Selected = false;
        currentSelected = true;
    }
        private void SelectedAllFalse()
        {
            _1Selected = false;
            _2Selected = false;
            _3Selected = false;
            _4Selected = false;
            _5Selected = false;
            _6Selected = false;
            _7Selected = false;
            _8Selected = false;
            _9Selected = false;
            _10Selected = false;
            _11Selected = false;
            _12Selected = false;
        }       

        private void _1_Click(object sender, RoutedEventArgs e)
        {
                _1Selected = true;
                _2Selected = false;
                _3Selected = false;
                _4Selected = false;
                _5Selected = false;
                _6Selected = false;
                _7Selected = false;
                _8Selected = false;
                _9Selected = false;
                _10Selected = false;
                _11Selected = false;
                _12Selected = false;
                BuildVisible();
                blackText.Text = " Build :";
        }
        private void _2_Click(object sender, RoutedEventArgs e)
        {
            _1Selected = false;
            _2Selected = true;
            _3Selected = false;
            _4Selected = false;
            _5Selected = false;
            _6Selected = false;
            _7Selected = false;
            _8Selected = false;
            _9Selected = false;
            _10Selected = false;
            _11Selected = false;
            _12Selected = false;
            BuildVisible();
            blackText.Text = " Build :";
        }
        private void _3_Click(object sender, RoutedEventArgs e)
        {
            _1Selected = false;
            _2Selected = false;
            _3Selected = true;
            _4Selected = false;
            _5Selected = false;
            _6Selected = false;
            _7Selected = false;
            _8Selected = false;
            _9Selected = false;
            _10Selected = false;
            _11Selected = false;
            _12Selected = false;
            BuildVisible();
            blackText.Text = " Build :";
        }
        private void _4_Click(object sender, RoutedEventArgs e)
        {
            _1Selected = false;
            _2Selected = false;
            _3Selected = false;
            _4Selected = true;
            _5Selected = false;
            _6Selected = false;
            _7Selected = false;
            _8Selected = false;
            _9Selected = false;
            _10Selected = false;
            _11Selected = false;
            _12Selected = false;
            BuildVisible();
            blackText.Text = " Build :";
        }
        private void _5_Click(object sender, RoutedEventArgs e)
        {
            _1Selected = false;
            _2Selected = false;
            _3Selected = false;
            _4Selected = false;
            _5Selected = true;
            _6Selected = false;
            _7Selected = false;
            _8Selected = false;
            _9Selected = false;
            _10Selected = false;
            _11Selected = false;
            _12Selected = false;
            BuildVisible();
            blackText.Text = " Build :";
        }
        private void _6_Click(object sender, RoutedEventArgs e)
        {
            _1Selected = false;
            _2Selected = false;
            _3Selected = false;
            _4Selected = false;
            _5Selected = false;
            _6Selected = true;
            _7Selected = false;
            _8Selected = false;
            _9Selected = false;
            _10Selected = false;
            _11Selected = false;
            _12Selected = false;
            BuildVisible();
            blackText.Text = " Build :";
        }
        private void _7_Click(object sender, RoutedEventArgs e)
        {
            _1Selected = false;
            _2Selected = false;
            _3Selected = false;
            _4Selected = false;
            _5Selected = false;
            _6Selected = false;
            _7Selected = true;
            _8Selected = false;
            _9Selected = false;
            _10Selected = false;
            _11Selected = false;
            _12Selected = false;
            BuildVisible();
            blackText.Text = " Build :";
        }
        private void _8_Click(object sender, RoutedEventArgs e)
        {
            _1Selected = false;
            _2Selected = false;
            _3Selected = false;
            _4Selected = false;
            _5Selected = false;
            _6Selected = false;
            _7Selected = false;
            _8Selected = true;
            _9Selected = false;
            _10Selected = false;
            _11Selected = false;
            _12Selected = false;
            BuildVisible();
            blackText.Text = " Build :";
        }
        private void _9_Click(object sender, RoutedEventArgs e)
        {
            _1Selected = false;
            _2Selected = false;
            _3Selected = false;
            _4Selected = false;
            _5Selected = false;
            _6Selected = false;
            _7Selected = false;
            _8Selected = false;
            _9Selected = true;
            _10Selected = false;
            _11Selected = false;
            _12Selected = false;
            BuildVisible();
            blackText.Text = " Build :";
        }
        private void _10_Click(object sender, RoutedEventArgs e)
        {
            _1Selected = false;
            _2Selected = false;
            _3Selected = false;
            _4Selected = false;
            _5Selected = false;
            _6Selected = false;
            _7Selected = false;
            _8Selected = false;
            _9Selected = false;
            _10Selected = true;
            _11Selected = false;
            _12Selected = false;
            BuildVisible();
            blackText.Text = " Build :";
        }
        private void _11_Click(object sender, RoutedEventArgs e)
        {
            _1Selected = false;
            _2Selected = false;
            _3Selected = false;
            _4Selected = false;
            _5Selected = false;
            _6Selected = false;
            _7Selected = false;
            _8Selected = false;
            _9Selected = false;
            _10Selected = false;
            _11Selected = true;
            _12Selected = false;
            BuildVisible();
            blackText.Text = " Build :";
        }
        private void _12_Click(object sender, RoutedEventArgs e)
        {
            _1Selected = false;
            _2Selected = false;
            _3Selected = false;
            _4Selected = false;
            _5Selected = false;
            _6Selected = false;
            _7Selected = false;
            _8Selected = false;
            _9Selected = false;
            _10Selected = false;
            _11Selected = false;
            _12Selected = true;
            BuildVisible();
            blackText.Text = " Build :";
        }

        private void Build_1_Click(object sender, RoutedEventArgs e)
        {

            NumberOfLumberCamps++;

            if (_1Selected == true)
            {
                _1.Content = "Lumber Camp";
                _1Selected = false;
                BuildHidden();
                blackText.Text = " Select a place to build";
            }
            else if (_2Selected == true)
            {
                _2.Content = "Lumber Camp";
                _2Selected = false;
                BuildHidden();
                blackText.Text = " Select a place to build";
            }
            else if (_3Selected == true)
            {
                _3.Content = "Lumber Camp";
                _3Selected = false;
                BuildHidden();
                blackText.Text = " Select a place to build";
            }
            else if (_4Selected == true)
            {
                _4.Content = "Lumber Camp";
                _5Selected = false;
                BuildHidden();
                blackText.Text = " Select a place to build";
            }
            else if (_5Selected == true)
            {
                _5.Content = "Lumber Camp";
                _5Selected = false;
                BuildHidden();
                blackText.Text = " Select a place to build";
            }
            else if (_6Selected == true)
            {
                _6.Content = "Lumber Camp";
                _6Selected = false;
                BuildHidden();
                blackText.Text = " Select a place to build";
            }
            else if (_7Selected == true)
            {
                _7.Content = "Lumber Camp";
                _7Selected = false;
                BuildHidden();
                blackText.Text = " Select a place to build";
            }
            else if (_8Selected == true)
            {
                _8.Content = "Lumber Camp";
                _8Selected = false;
                BuildHidden();
                blackText.Text = " Select a place to build";
            }
            else if (_9Selected == true)
            {
                _9.Content = "Lumber Camp";
                _9Selected = false;
                BuildHidden();
                blackText.Text = " Select a place to build";
            }
            else if (_10Selected == true)
            {
                _10.Content = "Lumber Camp";
                _10Selected = false;
                BuildHidden();
                blackText.Text = " Select a place to build";
            }
            else if (_11Selected == true)
            {
                _11.Content = "Lumber Camp";
                _11Selected = false;
                BuildHidden();
                blackText.Text = " Select a place to build";
            }
            else if (_12Selected == true)
            {
                _12.Content = "Lumber Camp";
                _12Selected = false;
                BuildHidden();
                blackText.Text = " Select a place to build";
            }
        }

        private void Build_2_Click(object sender, RoutedEventArgs e)
        {
            NumberOfStoneCamps++;

            if (_1Selected == true)
            {
                _1.Content = "Stone Camp";
                _1Selected = false;
                BuildHidden();
                blackText.Text = " Select a place to build";
            }else if (_2Selected == true)
            {
                _2.Content = "Stone Camp";
                _2Selected = false;
                BuildHidden();
                blackText.Text = " Select a place to build";
            }
            else if (_3Selected == true)
            {
                _3.Content = "Stone Camp";
                _3Selected = false;
                BuildHidden();
                blackText.Text = " Select a place to build";
            }
            else if (_4Selected == true)
            {
                _4.Content = "Stone Camp";
                _4Selected = false;
                BuildHidden();
                blackText.Text = " Select a place to build";
            }
            else if (_5Selected == true)
            {
                _5.Content = "Stone Camp";
                _5Selected = false;
                BuildHidden();
                blackText.Text = " Select a place to build";
            }
            else if (_6Selected == true)
            {
                _6.Content = "Stone Camp";
                _6Selected = false;
                BuildHidden();
                blackText.Text = " Select a place to build";
            }
            else if (_7Selected == true)
            {
                _7.Content = "Stone Camp";
                _7Selected = false;
                BuildHidden();
                blackText.Text = " Select a place to build";
            }
            else if (_8Selected == true)
            {
                _8.Content = "Stone Camp";
                _8Selected = false;
                BuildHidden();
                blackText.Text = " Select a place to build";
            }
            else if (_9Selected == true)
            {
                _9.Content = "Stone Camp";
                _9Selected = false;
                BuildHidden();
                blackText.Text = " Select a place to build";
            }
            else if (_10Selected == true)
            {
                _10.Content = "Stone Camp";
                _10Selected = false;
                BuildHidden();
                blackText.Text = " Select a place to build";
            }
            else if (_11Selected == true)
            {
                _11.Content = "Stone Camp";
                _11Selected = false;
                BuildHidden();
                blackText.Text = " Select a place to build";
            }
            else if (_12Selected == true)
            {
                _12.Content = "Stone Camp";
                _12Selected = false;
                BuildHidden();
                blackText.Text = " Select a place to build";
            }
        }
    }
}
