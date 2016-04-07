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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace JTC_Games_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public static String jacksUsername = "jack123";
        public static String jacksPassword = "tigers123";

        public static String lachysUsername = "lachy123";
        public static String lachysPassword = "fat";

        public static String tomsUsername = "tom3912";
        public static String tomsPassword = "clarke18";

        public static bool usernameCorrect = false;
        public static bool passwordCorrect = false;

        public MainWindow()
        {
            MainGameWindow mainGameWindow = new MainGameWindow();
            mainGameWindow.Show();
            this.Close();
            InitializeComponent();
        }

        private void EXIT_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void LOGIN_Click(object sender, RoutedEventArgs e)
        {

            if (USERNAME_INPUT.Text == jacksUsername && PASSWORD_INPUT.Text == jacksPassword)
            {
                usernameCorrect = true;
                passwordCorrect = true;

            }
            else if (USERNAME_INPUT.Text == lachysUsername && PASSWORD_INPUT.Text == lachysPassword)
            {
                usernameCorrect = true;
                passwordCorrect = true;
            }
            else if (USERNAME_INPUT.Text == tomsUsername && PASSWORD_INPUT.Text == tomsPassword)
            {
                usernameCorrect = true;
                passwordCorrect = true;

            }

            if (usernameCorrect == true && passwordCorrect == true)
            {

                MainGameWindow mainGameWindow = new MainGameWindow();
                mainGameWindow.Show();
                this.Close();

            }
            else
            {
                //Testing if it's false each time...
                bool isWindowOpen = false;

                //For each Window in the current list of Windows then...
                foreach (Window theWindow in Application.Current.Windows)
                {
                    //...if the variable theWindow is the LoginDetailsWrong window then...
                    if (theWindow is LoginDetailsWrong)
                    {
                        isWindowOpen = true;
                        theWindow.Activate();
                    }
                }
                //LoginDetailsWrong window doesn't exist!
                //Make one...
                if (!isWindowOpen)
                {
                    LoginDetailsWrong newWindow = new LoginDetailsWrong();
                    newWindow.Show();
                }

            }
        }
    }
}
