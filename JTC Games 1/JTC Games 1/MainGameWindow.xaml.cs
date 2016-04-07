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
        public static int currentLumber = 850;
        public static int lumberCampCostWood = 250;
        public static int lumberCampCostWorkers = 10;

        public static int NumberOfStoneCamps = 0;
        public static int currentStone = 25;
        public static int stoneCampCostWood = 250;
        public static int stoneCampCostWorkers = 30;

        public static int NumberOfIronCamps = 0;
        public static int currentIron = 50;
        public static int ironCampCostStone = 35;
        public static int ironCampCostWorkers = 25;

        public static int NumberOfGoldCamps = 0;
        public static int currentGold = 20;
        public static int goldCampCostIron = 120;
        public static int goldCampCostWorkers = 40;

        public static int NumberOfFoodCamps = 0;
        public static int currentFood = 125;
        public static int foodCampCostWood = 100;
        public static int foodCampCostWorkers = 20;

        public static int NumberOfWaterCamps = 0;
        public static int currentWater = 20;
        public static int waterCampCostWood = 85;
        public static int waterCampCostWorkers = 12;

        public static int NumberOfWorkers = 0;
        public static int currentWorkers = 30;
        public static int workersCampCostWood = 300;
        public static int workersCampCostFood = 20;


        public MainGameWindow()
        {
            InitializeComponent();


            #region Lumber Timer  100/ms

            System.Windows.Threading.DispatcherTimer LumberTimer = new System.Windows.Threading.DispatcherTimer();
            LumberTimer.Tick += new EventHandler(LumberTimer_Tick);
            LumberTimer.Interval = new TimeSpan(0, 0, 0, 0, 100);
            LumberTimer.Start();

            #endregion

            #region Stone Timer  800/ms

            System.Windows.Threading.DispatcherTimer StoneTimer = new System.Windows.Threading.DispatcherTimer();
            StoneTimer.Tick += new EventHandler(StoneTimer_Tick);
            StoneTimer.Interval = new TimeSpan(0, 0, 0, 0, 800);
            StoneTimer.Start();

            #endregion

            #region Iron Timer  500/ms

            System.Windows.Threading.DispatcherTimer IronTimer = new System.Windows.Threading.DispatcherTimer();
            IronTimer.Tick += new EventHandler(IronTimer_Tick);
            IronTimer.Interval = new TimeSpan(0, 0, 0, 0, 500);
            IronTimer.Start();

            #endregion

            #region Gold Timer  600/ms

            System.Windows.Threading.DispatcherTimer goldTimer = new System.Windows.Threading.DispatcherTimer();
            goldTimer.Tick += new EventHandler(GoldTimer_Tick);
            goldTimer.Interval = new TimeSpan(0, 0, 0, 0, 600);
            goldTimer.Start();

            #endregion

            #region Food Timer  200/ms

            System.Windows.Threading.DispatcherTimer foodTimer = new System.Windows.Threading.DispatcherTimer();
            foodTimer.Tick += new EventHandler(FoodTimer_Tick);
            foodTimer.Interval = new TimeSpan(0, 0, 0, 0, 200);
            foodTimer.Start();

            #endregion

            #region Water Timer  1000/ms

            System.Windows.Threading.DispatcherTimer waterTimer = new System.Windows.Threading.DispatcherTimer();
            waterTimer.Tick += new EventHandler(WaterTimer_Tick);
            waterTimer.Interval = new TimeSpan(0, 0, 0, 1);
            waterTimer.Start();

            #endregion

            #region Workers Timer  3000/ms

            System.Windows.Threading.DispatcherTimer workersTimer = new System.Windows.Threading.DispatcherTimer();
            workersTimer.Tick += new EventHandler(WorkersTimer_Tick);
            workersTimer.Interval = new TimeSpan(0, 0, 0, 2);
            workersTimer.Start();

            #endregion

            #region Timer1  1/ms

            System.Windows.Threading.DispatcherTimer Timer1 = new System.Windows.Threading.DispatcherTimer();
            Timer1.Tick += new EventHandler(Timer1_Tick);
            Timer1.Interval = new TimeSpan(0, 0, 0, 0, 200);
            Timer1.Start();

            #endregion


            BuildHidden();
            blackText.Text = " Select a place to build";

            CurrentLumberCount.Text = "" + currentLumber;
            CurrentStoneCount.Text = "" + currentStone;
            CurrentIronCount.Text = "" + currentIron;
            CurrentGoldCount.Text = "" + currentGold;
            CurrentFoodCount.Text = "" + currentFood;
            CurrentWaterCount.Text = "" + currentWater;
            CurrentWorkersCount.Text = "" + currentWorkers;
        }


        private void LumberTimer_Tick(object sender, EventArgs e)
        {
            if (NumberOfLumberCamps >= 1)
            {
                currentLumber = currentLumber + NumberOfLumberCamps;
                CurrentLumberCount.Text = "" + currentLumber;
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {

            CurrentLumberCount.Text = "" + currentLumber;
            CurrentStoneCount.Text = "" + currentStone;
            CurrentIronCount.Text = "" + currentIron;
            CurrentGoldCount.Text = "" + currentGold;
            CurrentFoodCount.Text = "" + currentFood;
            CurrentWaterCount.Text = "" + currentWater;
            CurrentWorkersCount.Text = "" + currentWorkers;

            if (_1.Content == "Lumber Camp" || _1.Content == "Stone Camp" || _1.Content == "Iron Camp" || _1.Content == "Iron Camp" || _1.Content == "Gold Camp" | _1.Content == "Water Mill" || _1.Content == "Farm")
            {
                _1Selected = false;
            }
            if (_2.Content == "Lumber Camp" || _2.Content == "Stone Camp" || _2.Content == "Iron Camp" || _2.Content == "Iron Camp" || _2.Content == "Gold Camp" | _2.Content == "Water Mill" || _2.Content == "Farm")
            {
                _2Selected = false;
            }
            if (_3.Content == "Lumber Camp" || _3.Content == "Stone Camp" || _3.Content == "Iron Camp" || _3.Content == "Iron Camp" || _3.Content == "Gold Camp" | _3.Content == "Water Mill" || _3.Content == "Farm")
            {
                _3Selected = false;
            }
            if (_4.Content == "Lumber Camp" || _4.Content == "Stone Camp" || _4.Content == "Iron Camp" || _4.Content == "Iron Camp" || _4.Content == "Gold Camp" | _4.Content == "Water Mill" || _4.Content == "Farm")
            {
                _4Selected = false;
            }
            if (_5.Content == "Lumber Camp" || _5.Content == "Stone Camp" || _5.Content == "Iron Camp" || _5.Content == "Iron Camp" || _5.Content == "Gold Camp" | _5.Content == "Water Mill" || _5.Content == "Farm")
            {
                _5Selected = false;
            }
            if (_6.Content == "Lumber Camp" || _6.Content == "Stone Camp" || _6.Content == "Iron Camp" || _6.Content == "Iron Camp" || _6.Content == "Gold Camp" | _6.Content == "Water Mill" || _6.Content == "Farm")
            {
                _6Selected = false;
            }
            if (_7.Content == "Lumber Camp" || _7.Content == "Stone Camp" || _7.Content == "Iron Camp" || _7.Content == "Iron Camp" || _7.Content == "Gold Camp" | _7.Content == "Water Mill" || _7.Content == "Farm")
            {
                _7Selected = false;
            }
            if (_8.Content == "Lumber Camp" || _8.Content == "Stone Camp" || _8.Content == "Iron Camp" || _8.Content == "Iron Camp" || _8.Content == "Gold Camp" | _8.Content == "Water Mill" || _8.Content == "Farm")
            {
                _8Selected = false;
            }
            if (_9.Content == "Lumber Camp" || _9.Content == "Stone Camp" || _9.Content == "Iron Camp" || _9.Content == "Iron Camp" || _9.Content == "Gold Camp" | _9.Content == "Water Mill" || _9.Content == "Farm")
            {
                _9Selected = false;
            }
            if (_10.Content == "Lumber Camp" || _10.Content == "Stone Camp" || _10.Content == "Iron Camp" || _10.Content == "Iron Camp" || _10.Content == "Gold Camp" | _10.Content == "Water Mill" || _10.Content == "Farm")
            {
                _10Selected = false;
            }
            if (_11.Content == "Lumber Camp" || _11.Content == "Stone Camp" || _11.Content == "Iron Camp" || _11.Content == "Iron Camp" || _11.Content == "Gold Camp" | _11.Content == "Water Mill" || _11.Content == "Farm")
            {
                _11Selected = false;
            }
            if (_12.Content == "Lumber Camp" || _12.Content == "Stone Camp" || _12.Content == "Iron Camp" || _12.Content == "Iron Camp" || _12.Content == "Gold Camp" | _12.Content == "Water Mill" || _12.Content == "Farm")
            {
                _12Selected = false;
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

        private void IronTimer_Tick(object sender, EventArgs e)
        {
            if (NumberOfIronCamps >= 1)
            {
                currentIron = currentIron + NumberOfIronCamps;
                CurrentIronCount.Text = "" + currentIron;
            }
        }

        private void GoldTimer_Tick(object sender, EventArgs e)
        {
            if (NumberOfGoldCamps >= 1)
            {
                currentGold = currentGold + NumberOfGoldCamps;
                CurrentGoldCount.Text = "" + currentGold;
            }
        }

        private void FoodTimer_Tick(object sender, EventArgs e)
        {
            if (NumberOfFoodCamps >= 1)
            {
                currentFood = currentFood + NumberOfFoodCamps;
                CurrentFoodCount.Text = "" + currentFood;
            }
        }

        private void WaterTimer_Tick(object sender, EventArgs e)
        {
            if (NumberOfWaterCamps >= 1)
            {
                currentWater = currentWater + NumberOfWaterCamps;
                CurrentWaterCount.Text = "" + currentWater;
            }
        }

        private void WorkersTimer_Tick(object sender, EventArgs e)
        {
            if (NumberOfWorkers >= 1)
            {
                currentWorkers = currentWorkers + NumberOfWorkers;
                CurrentWorkersCount.Text = "" + currentWorkers;
            }
        }

        private void NormalBuildVisible()
        {
            blackText.Visibility = Visibility.Visible;
            Build_1.Visibility = Visibility.Visible;
            Build_2.Visibility = Visibility.Visible;
            Build_3.Visibility = Visibility.Visible;
            Build_4.Visibility = Visibility.Visible;
            Build_5.Visibility = Visibility.Visible;
            Build_6.Visibility = Visibility.Visible;
            Build_7.Visibility = Visibility.Visible;
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

        private void SelectedFalse(bool currentSelected)
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
            NormalBuildVisible();
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
            NormalBuildVisible();
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
            NormalBuildVisible();
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
            NormalBuildVisible();
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
            NormalBuildVisible();
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
            NormalBuildVisible();
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
            NormalBuildVisible();
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
            NormalBuildVisible();
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
            NormalBuildVisible();
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
            NormalBuildVisible();
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
            NormalBuildVisible();
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
            NormalBuildVisible();
            blackText.Text = " Build :";
        }

        private void Build_1_Click(object sender, RoutedEventArgs e)
        {

            if (_1Selected == true || _2Selected == true || _3Selected == true || _4Selected == true || _5Selected == true || _6Selected == true || _7Selected == true || _8Selected == true || _9Selected == true || _10Selected == true || _11Selected == true || _12Selected == true)
            {

                if (currentLumber >= lumberCampCostWood && currentWorkers >= lumberCampCostWorkers)
                {
                    currentLumber = currentLumber - lumberCampCostWood;
                    currentWorkers = currentWorkers - lumberCampCostWorkers;
                    lumberCampCostWood += 50;
                    lumberCampCostWorkers += 10;
                    NumberOfLumberCamps++;

                    if (_1Selected == true)
                    {
                        _1.Content = "Lumber Camp";
                        _1.Background = Brushes.SaddleBrown;
                        _1Selected = false;
                        BuildHidden();
                        blackText.Text = " Select a place to build";
                    }
                    else if (_2Selected == true)
                    {
                        _2.Content = "Lumber Camp";
                        _2.Background = Brushes.SaddleBrown;
                        _2Selected = false;
                        BuildHidden();
                        blackText.Text = " Select a place to build";
                    }
                    else if (_3Selected == true)
                    {
                        _3.Content = "Lumber Camp";
                        _3.Background = Brushes.SaddleBrown;
                        _3Selected = false;
                        BuildHidden();
                        blackText.Text = " Select a place to build";
                    }
                    else if (_4Selected == true)
                    {
                        _4.Content = "Lumber Camp";
                        _4.Background = Brushes.SaddleBrown;
                        _5Selected = false;
                        BuildHidden();
                        blackText.Text = " Select a place to build";
                    }
                    else if (_5Selected == true)
                    {
                        _5.Content = "Lumber Camp";
                        _5.Background = Brushes.SaddleBrown;
                        _5Selected = false;
                        BuildHidden();
                        blackText.Text = " Select a place to build";
                    }
                    else if (_6Selected == true)
                    {
                        _6.Content = "Lumber Camp";
                        _6.Background = Brushes.SaddleBrown;
                        _6Selected = false;
                        BuildHidden();
                        blackText.Text = " Select a place to build";
                    }
                    else if (_7Selected == true)
                    {
                        _7.Content = "Lumber Camp";
                        _7.Background = Brushes.SaddleBrown;
                        _7Selected = false;
                        BuildHidden();
                        blackText.Text = " Select a place to build";
                    }
                    else if (_8Selected == true)
                    {
                        _8.Content = "Lumber Camp";
                        _8.Background = Brushes.SaddleBrown;
                        _8Selected = false;
                        BuildHidden();
                        blackText.Text = " Select a place to build";
                    }
                    else if (_9Selected == true)
                    {
                        _9.Content = "Lumber Camp";
                        _9.Background = Brushes.SaddleBrown;
                        _9Selected = false;
                        BuildHidden();
                        blackText.Text = " Select a place to build";
                    }
                    else if (_10Selected == true)
                    {
                        _10.Content = "Lumber Camp";
                        _10.Background = Brushes.SaddleBrown;
                        _10Selected = false;
                        BuildHidden();
                        blackText.Text = " Select a place to build";
                    }
                    else if (_11Selected == true)
                    {
                        _11.Content = "Lumber Camp";
                        _11.Background = Brushes.SaddleBrown;
                        _11Selected = false;
                        BuildHidden();
                        blackText.Text = " Select a place to build";
                    }
                    else if (_12Selected == true)
                    {
                        _12.Content = "Lumber Camp";
                        _12.Background = Brushes.SaddleBrown;
                        _12Selected = false;
                        BuildHidden();
                        blackText.Text = " Select a place to build";
                    }
                }
            }
        }

        private void Build_2_Click(object sender, RoutedEventArgs e)
        {

            if (_1Selected == true || _2Selected == true || _3Selected == true || _4Selected == true || _5Selected == true || _6Selected == true || _7Selected == true || _8Selected == true || _9Selected == true || _10Selected == true || _11Selected == true || _12Selected == true)
            {

                if (currentLumber >= stoneCampCostWood && currentWorkers >= stoneCampCostWorkers)
                {
                    currentLumber = currentLumber - stoneCampCostWood;
                    currentWorkers = currentWorkers - stoneCampCostWorkers;
                    stoneCampCostWood += 100;
                    stoneCampCostWorkers += 10;
                    NumberOfStoneCamps++;

                    if (_1Selected == true)
                    {
                        _1.Content = "Stone Camp";
                        _1.Background = Brushes.DarkGray;
                        _1Selected = false;
                        BuildHidden();
                        blackText.Text = " Select a place to build";
                    }
                    else if (_2Selected == true)
                    {
                        _2.Content = "Stone Camp";
                        _2.Background = Brushes.DarkGray;
                        _2Selected = false;
                        BuildHidden();
                        blackText.Text = " Select a place to build";
                    }
                    else if (_3Selected == true)
                    {
                        _3.Content = "Stone Camp";
                        _3.Background = Brushes.DarkGray;
                        _3Selected = false;
                        BuildHidden();
                        blackText.Text = " Select a place to build";
                    }
                    else if (_4Selected == true)
                    {
                        _4.Content = "Stone Camp";
                        _4.Background = Brushes.DarkGray;
                        _4Selected = false;
                        BuildHidden();
                        blackText.Text = " Select a place to build";
                    }
                    else if (_5Selected == true)
                    {
                        _5.Content = "Stone Camp";
                        _5.Background = Brushes.DarkGray;
                        _5Selected = false;
                        BuildHidden();
                        blackText.Text = " Select a place to build";
                    }
                    else if (_6Selected == true)
                    {
                        _6.Content = "Stone Camp";
                        _6.Background = Brushes.DarkGray;
                        _6Selected = false;
                        BuildHidden();
                        blackText.Text = " Select a place to build";
                    }
                    else if (_7Selected == true)
                    {
                        _7.Content = "Stone Camp";
                        _7.Background = Brushes.DarkGray;
                        _7Selected = false;
                        BuildHidden();
                        blackText.Text = " Select a place to build";
                    }
                    else if (_8Selected == true)
                    {
                        _8.Content = "Stone Camp";
                        _8.Background = Brushes.DarkGray;
                        _8Selected = false;
                        BuildHidden();
                        blackText.Text = " Select a place to build";
                    }
                    else if (_9Selected == true)
                    {
                        _9.Content = "Stone Camp";
                        _9.Background = Brushes.DarkGray;
                        _9Selected = false;
                        BuildHidden();
                        blackText.Text = " Select a place to build";
                    }
                    else if (_10Selected == true)
                    {
                        _10.Content = "Stone Camp";
                        _10.Background = Brushes.DarkGray;
                        _10Selected = false;
                        BuildHidden();
                        blackText.Text = " Select a place to build";
                    }
                    else if (_11Selected == true)
                    {
                        _11.Content = "Stone Camp";
                        _11.Background = Brushes.DarkGray;
                        _11Selected = false;
                        BuildHidden();
                        blackText.Text = " Select a place to build";
                    }
                    else if (_12Selected == true)
                    {
                        _12.Content = "Stone Camp";
                        _12.Background = Brushes.DarkGray;
                        _12Selected = false;
                        BuildHidden();
                        blackText.Text = " Select a place to build";
                    }

                }
            }
        }

        private void Build_3_Click(object sender, RoutedEventArgs e)
        {

            if (_1Selected == true || _2Selected == true || _3Selected == true || _4Selected == true || _5Selected == true || _6Selected == true || _7Selected == true || _8Selected == true || _9Selected == true || _10Selected == true || _11Selected == true || _12Selected == true)
            {

                if (currentStone >= ironCampCostStone && currentWorkers >= goldCampCostWorkers)
                {
                    currentStone = currentStone - ironCampCostStone;
                    currentWorkers = currentWorkers - ironCampCostWorkers;
                    ironCampCostStone += 60;
                    ironCampCostWorkers += 10;
                    NumberOfIronCamps++;

                    if (_1Selected == true)
                    {
                        _1.Content = "Iron Camp";
                        _1Selected = false;
                        BuildHidden();
                        blackText.Text = " Select a place to build";
                    }
                    else if (_2Selected == true)
                    {
                        _2.Content = "Iron Camp";
                        _2Selected = false;
                        BuildHidden();
                        blackText.Text = " Select a place to build";
                    }
                    else if (_3Selected == true)
                    {
                        _3.Content = "Iron Camp";
                        _3Selected = false;
                        BuildHidden();
                        blackText.Text = " Select a place to build";
                    }
                    else if (_4Selected == true)
                    {
                        _4.Content = "Iron Camp";
                        _4Selected = false;
                        BuildHidden();
                        blackText.Text = " Select a place to build";
                    }
                    else if (_5Selected == true)
                    {
                        _5.Content = "Iron Camp";
                        _5Selected = false;
                        BuildHidden();
                        blackText.Text = " Select a place to build";
                    }
                    else if (_6Selected == true)
                    {
                        _6.Content = "Iron Camp";
                        _6Selected = false;
                        BuildHidden();
                        blackText.Text = " Select a place to build";
                    }
                    else if (_7Selected == true)
                    {
                        _7.Content = "Iron Camp";
                        _7Selected = false;
                        BuildHidden();
                        blackText.Text = " Select a place to build";
                    }
                    else if (_8Selected == true)
                    {
                        _8.Content = "Iron Camp";
                        _8Selected = false;
                        BuildHidden();
                        blackText.Text = " Select a place to build";
                    }
                    else if (_9Selected == true)
                    {
                        _9.Content = "Iron Camp";
                        _9Selected = false;
                        BuildHidden();
                        blackText.Text = " Select a place to build";
                    }
                    else if (_10Selected == true)
                    {
                        _10.Content = "Iron Camp";
                        _10Selected = false;
                        BuildHidden();
                        blackText.Text = " Select a place to build";
                    }
                    else if (_11Selected == true)
                    {
                        _11.Content = "Iron Camp";
                        _11Selected = false;
                        BuildHidden();
                        blackText.Text = " Select a place to build";
                    }
                    else if (_12Selected == true)
                    {
                        _12.Content = "Iron Camp";
                        _12Selected = false;
                        BuildHidden();
                        blackText.Text = " Select a place to build";
                    }

                }
            }
        }

        private void Build_4_Click(object sender, RoutedEventArgs e)
        {

            if (_1Selected == true || _2Selected == true || _3Selected == true || _4Selected == true || _5Selected == true || _6Selected == true || _7Selected == true || _8Selected == true || _9Selected == true || _10Selected == true || _11Selected == true || _12Selected == true)
            {

                if (currentLumber >= goldCampCostIron && currentWorkers >= goldCampCostWorkers)
                {
                    currentIron = currentIron - goldCampCostIron;
                    currentWorkers = currentWorkers - goldCampCostWorkers;
                    goldCampCostIron += 50;
                    goldCampCostWorkers += 10;
                    NumberOfGoldCamps++;

                    if (_1Selected == true)
                    {
                        _1.Content = "Gold Camp";
                        _1Selected = false;
                        BuildHidden();
                        blackText.Text = " Select a place to build";
                    }
                    else if (_2Selected == true)
                    {
                        _2.Content = "Gold Camp";
                        _2Selected = false;
                        BuildHidden();
                        blackText.Text = " Select a place to build";
                    }
                    else if (_3Selected == true)
                    {
                        _3.Content = "Gold Camp";
                        _3Selected = false;
                        BuildHidden();
                        blackText.Text = " Select a place to build";
                    }
                    else if (_4Selected == true)
                    {
                        _4.Content = "Gold Camp";
                        _4Selected = false;
                        BuildHidden();
                        blackText.Text = " Select a place to build";
                    }
                    else if (_5Selected == true)
                    {
                        _5.Content = "Gold Camp";
                        _5Selected = false;
                        BuildHidden();
                        blackText.Text = " Select a place to build";
                    }
                    else if (_6Selected == true)
                    {
                        _6.Content = "Gold Camp";
                        _6Selected = false;
                        BuildHidden();
                        blackText.Text = " Select a place to build";
                    }
                    else if (_7Selected == true)
                    {
                        _7.Content = "Gold Camp";
                        _7Selected = false;
                        BuildHidden();
                        blackText.Text = " Select a place to build";
                    }
                    else if (_8Selected == true)
                    {
                        _8.Content = "Gold Camp";
                        _8Selected = false;
                        BuildHidden();
                        blackText.Text = " Select a place to build";
                    }
                    else if (_9Selected == true)
                    {
                        _9.Content = "Gold Camp";
                        _9Selected = false;
                        BuildHidden();
                        blackText.Text = " Select a place to build";
                    }
                    else if (_10Selected == true)
                    {
                        _10.Content = "Gold Camp";
                        _10Selected = false;
                        BuildHidden();
                        blackText.Text = " Select a place to build";
                    }
                    else if (_11Selected == true)
                    {
                        _11.Content = "Gold Camp";
                        _11Selected = false;
                        BuildHidden();
                        blackText.Text = " Select a place to build";
                    }
                    else if (_12Selected == true)
                    {
                        _12.Content = "Gold Camp";
                        _12Selected = false;
                        BuildHidden();
                        blackText.Text = " Select a place to build";
                    }

                }
            }
        }

        private void Build_5_Click(object sender, RoutedEventArgs e)
        {

            if (_1Selected == true || _2Selected == true || _3Selected == true || _4Selected == true || _5Selected == true || _6Selected == true || _7Selected == true || _8Selected == true || _9Selected == true || _10Selected == true || _11Selected == true || _12Selected == true)
            {

                if (currentLumber >= foodCampCostWood && currentWorkers >= foodCampCostWorkers)
                {
                    currentLumber = currentLumber - foodCampCostWood;
                    currentWorkers = currentWorkers - foodCampCostWorkers;
                    foodCampCostWood += 50;
                    foodCampCostWorkers += 10;
                    NumberOfFoodCamps++;

                    if (_1Selected == true)
                    {
                        _1.Content = "Farm";
                        _1Selected = false;
                        BuildHidden();
                        blackText.Text = " Select a place to build";
                    }
                    else if (_2Selected == true)
                    {
                        _2.Content = "Farm";
                        _2Selected = false;
                        BuildHidden();
                        blackText.Text = " Select a place to build";
                    }
                    else if (_3Selected == true)
                    {
                        _3.Content = "Farm";
                        _3Selected = false;
                        BuildHidden();
                        blackText.Text = " Select a place to build";
                    }
                    else if (_4Selected == true)
                    {
                        _4.Content = "Farm";
                        _4Selected = false;
                        BuildHidden();
                        blackText.Text = " Select a place to build";
                    }
                    else if (_5Selected == true)
                    {
                        _5.Content = "Farm";
                        _5Selected = false;
                        BuildHidden();
                        blackText.Text = " Select a place to build";
                    }
                    else if (_6Selected == true)
                    {
                        _6.Content = "Farm";
                        _6Selected = false;
                        BuildHidden();
                        blackText.Text = " Select a place to build";
                    }
                    else if (_7Selected == true)
                    {
                        _7.Content = "Farm";
                        _7Selected = false;
                        BuildHidden();
                        blackText.Text = " Select a place to build";
                    }
                    else if (_8Selected == true)
                    {
                        _8.Content = "Farm";
                        _8Selected = false;
                        BuildHidden();
                        blackText.Text = " Select a place to build";
                    }
                    else if (_9Selected == true)
                    {
                        _9.Content = "Farm";
                        _9Selected = false;
                        BuildHidden();
                        blackText.Text = " Select a place to build";
                    }
                    else if (_10Selected == true)
                    {
                        _10.Content = "Farm";
                        _10Selected = false;
                        BuildHidden();
                        blackText.Text = " Select a place to build";
                    }
                    else if (_11Selected == true)
                    {
                        _11.Content = "Farm";
                        _11Selected = false;
                        BuildHidden();
                        blackText.Text = " Select a place to build";
                    }
                    else if (_12Selected == true)
                    {
                        _12.Content = "Farm";
                        _12Selected = false;
                        BuildHidden();
                        blackText.Text = " Select a place to build";
                    }

                }
            }
        }

        private void Build_6_Click(object sender, RoutedEventArgs e)
        {

            if (_1Selected == true || _2Selected == true || _3Selected == true || _4Selected == true || _5Selected == true || _6Selected == true || _7Selected == true || _8Selected == true || _9Selected == true || _10Selected == true || _11Selected == true || _12Selected == true)
            {

                if (currentLumber >= stoneCampCostWood && currentWorkers >= waterCampCostWorkers)
                {
                    currentLumber = currentLumber - waterCampCostWood;
                    currentWorkers = currentWorkers - waterCampCostWorkers;
                    waterCampCostWood += 100;
                    waterCampCostWorkers += 10;
                    NumberOfWaterCamps++;

                    if (_1Selected == true)
                    {
                        _1.Content = "Water Mill";
                        _1Selected = false;
                        BuildHidden();
                        blackText.Text = " Select a place to build";
                    }
                    else if (_2Selected == true)
                    {
                        _2.Content = "Water Mill";
                        _2Selected = false;
                        BuildHidden();
                        blackText.Text = " Select a place to build";
                    }
                    else if (_3Selected == true)
                    {
                        _3.Content = "Water Mill";
                        _3Selected = false;
                        BuildHidden();
                        blackText.Text = " Select a place to build";
                    }
                    else if (_4Selected == true)
                    {
                        _4.Content = "Water Mill";
                        _4Selected = false;
                        BuildHidden();
                        blackText.Text = " Select a place to build";
                    }
                    else if (_5Selected == true)
                    {
                        _5.Content = "Water Mill";
                        _5Selected = false;
                        BuildHidden();
                        blackText.Text = " Select a place to build";
                    }
                    else if (_6Selected == true)
                    {
                        _6.Content = "Water Mill";
                        _6Selected = false;
                        BuildHidden();
                        blackText.Text = " Select a place to build";
                    }
                    else if (_7Selected == true)
                    {
                        _7.Content = "Water Mill";
                        _7Selected = false;
                        BuildHidden();
                        blackText.Text = " Select a place to build";
                    }
                    else if (_8Selected == true)
                    {
                        _8.Content = "Water Mill";
                        _8Selected = false;
                        BuildHidden();
                        blackText.Text = " Select a place to build";
                    }
                    else if (_9Selected == true)
                    {
                        _9.Content = "Water Mill";
                        _9Selected = false;
                        BuildHidden();
                        blackText.Text = " Select a place to build";
                    }
                    else if (_10Selected == true)
                    {
                        _10.Content = "Water Mill";
                        _10Selected = false;
                        BuildHidden();
                        blackText.Text = " Select a place to build";
                    }
                    else if (_11Selected == true)
                    {
                        _11.Content = "Water Mill";
                        _11Selected = false;
                        BuildHidden();
                        blackText.Text = " Select a place to build";
                    }
                    else if (_12Selected == true)
                    {
                        _12.Content = "Water Mill";
                        _12Selected = false;
                        BuildHidden();
                        blackText.Text = " Select a place to build";
                    }
                }
            }
        }

        private void Build_7_Click(object sender, RoutedEventArgs e)
        {
            if (_1Selected == true || _2Selected == true || _3Selected == true || _4Selected == true || _5Selected == true || _6Selected == true || _7Selected == true || _8Selected == true || _9Selected == true || _10Selected == true || _11Selected == true || _12Selected == true)
            {

                if (currentLumber >= workersCampCostWood && currentFood >= workersCampCostFood)
                {
                    currentLumber = currentLumber - workersCampCostWood;
                    currentFood = currentFood - workersCampCostFood;
                    workersCampCostFood += 40;
                    workersCampCostWood += 100;
                    NumberOfWorkers++;

                    if (_1Selected == true)
                    {
                        _1.Content = "Worker's Hut";
                        _1Selected = false;
                        BuildHidden();
                        blackText.Text = " Select a place to build";
                    }
                    else if (_2Selected == true)
                    {
                        _2.Content = "Worker's Hut";
                        _2Selected = false;
                        BuildHidden();
                        blackText.Text = " Select a place to build";
                    }
                    else if (_3Selected == true)
                    {
                        _3.Content = "Worker's Hut";
                        _3Selected = false;
                        BuildHidden();
                        blackText.Text = " Select a place to build";
                    }
                    else if (_4Selected == true)
                    {
                        _4.Content = "Worker's Hut";
                        _4Selected = false;
                        BuildHidden();
                        blackText.Text = " Select a place to build";
                    }
                    else if (_5Selected == true)
                    {
                        _5.Content = "Worker's Hut";
                        _5Selected = false;
                        BuildHidden();
                        blackText.Text = " Select a place to build";
                    }
                    else if (_6Selected == true)
                    {
                        _6.Content = "Worker's Hut";
                        _6Selected = false;
                        BuildHidden();
                        blackText.Text = " Select a place to build";
                    }
                    else if (_7Selected == true)
                    {
                        _7.Content = "Worker's Hut";
                        _7Selected = false;
                        BuildHidden();
                        blackText.Text = " Select a place to build";
                    }
                    else if (_8Selected == true)
                    {
                        _8.Content = "Worker's Hut";
                        _8Selected = false;
                        BuildHidden();
                        blackText.Text = " Select a place to build";
                    }
                    else if (_9Selected == true)
                    {
                        _9.Content = "Worker's Hut";
                        _9Selected = false;
                        BuildHidden();
                        blackText.Text = " Select a place to build";
                    }
                    else if (_10Selected == true)
                    {
                        _10.Content = "Worker's Hut";
                        _10Selected = false;
                        BuildHidden();
                        blackText.Text = " Select a place to build";
                    }
                    else if (_11Selected == true)
                    {
                        _11.Content = "Worker's Hut";
                        _11Selected = false;
                        BuildHidden();
                        blackText.Text = " Select a place to build";
                    }
                    else if (_12Selected == true)
                    {
                        _12.Content = "Worker's Hut";
                        _12Selected = false;
                        BuildHidden();
                        blackText.Text = " Select a place to build";
                    }
                }
            }
        }


        private void Build_1_MouseEnter(object sender, MouseEventArgs e)
        {
            Cost.Text = "Cost : " + lumberCampCostWood + " Wood" + " " + lumberCampCostWorkers + " Workers";
            Details.Text = "Details :   Produces Wood on a set Timer. Upgrade to get more wood per tick of the Timer";
        }

        private void Build_1_MouseLeave(object sender, MouseEventArgs e)
        {
            Cost.Text = "Cost :";
            Details.Text = "Details :";
        }

        private void Build_2_MouseEnter(object sender, MouseEventArgs e)
        {
            Cost.Text = "Cost : " + stoneCampCostWood + " Wood" + " " + stoneCampCostWorkers + " Workers";
            Details.Text = "Details :   Produces Stone on a set Timer. Upgrade to get more stone per tick of the Timer";
        }

        private void Build_2_MouseLeave(object sender, MouseEventArgs e)
        {
            Cost.Text = "Cost :";
            Details.Text = "Details :";
        }

        private void Build_3_MouseEnter(object sender, MouseEventArgs e)
        {
            Cost.Text = "Cost : " + ironCampCostStone + " Stone" + " " + stoneCampCostWorkers + " Workers";
            Details.Text = "Details :   Produces Iron on a set Timer. Upgrade to get more iron per tick of the Timer";
        }

        private void Build_3_MouseLeave(object sender, MouseEventArgs e)
        {
            Cost.Text = "Cost :";
            Details.Text = "Details :";
        }

        private void Build_4_MouseEnter(object sender, MouseEventArgs e)
        {
            Cost.Text = "Cost : " + goldCampCostIron + " Iron" + " " + goldCampCostWorkers + " Workers";
            Details.Text = "Details :   Produces Gold on a set Timer. Upgrade to get more gold per tick of the Timer";
        }

        private void Build_4_MouseLeave(object sender, MouseEventArgs e)
        {
            Cost.Text = "Cost :";
            Details.Text = "Details :";
        }

        private void Build_5_MouseEnter(object sender, MouseEventArgs e)
        {
            Cost.Text = "Cost : " + foodCampCostWood + " Wood" + " " + foodCampCostWorkers + " Workers";
            Details.Text = "Details :   Produces Food on a set Timer. Upgrade to get more food per tick of the Timer";
        }

        private void Build_5_MouseLeave(object sender, MouseEventArgs e)
        {
            Cost.Text = "Cost :";
            Details.Text = "Details :";
        }

        private void Build_6_MouseEnter(object sender, MouseEventArgs e)
        {
            Cost.Text = "Cost : " + waterCampCostWood + " Wood" + " " + waterCampCostWorkers + " Workers";
            Details.Text = "Details :   Produces Water on a set Timer. Upgrade to get more water per tick of the Timer";
        }

        private void Build_6_MouseLeave(object sender, MouseEventArgs e)
        {
            Cost.Text = "Cost :";
            Details.Text = "Details :";
        }

        private void Build_7_MouseEnter(object sender, MouseEventArgs e)
        {
            Cost.Text = "Cost : " + workersCampCostWood + " Wood" + " " + workersCampCostFood + " Food";
            Details.Text = "Details :   Produces a Worker every 3 seconds. Upgrade to get more Workers per 3 seconds";
        }

        private void Build_7_MouseLeave(object sender, MouseEventArgs e)
        {
            Cost.Text = "Cost :";
            Details.Text = "Details :";
        }



        private void button_Click(object sender, RoutedEventArgs e)
        {
            TownNavigation townPage = new TownNavigation();
            townPage.Show();
        }
    }
}
