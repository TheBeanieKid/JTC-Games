﻿using System;
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
        }

        private void Deck_Click(object sender, RoutedEventArgs e)
        {
            MainDeckWindow deckWindow = new MainDeckWindow();
            deckWindow.Show();
        }
    }
}
