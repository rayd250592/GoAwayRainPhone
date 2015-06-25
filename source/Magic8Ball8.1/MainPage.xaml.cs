using System;
using System.Windows;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;

namespace Magic8Ball
{
    public class MainPage : PhoneApplicationPage
    {
        // Constructor


        public MainPage()
        {
            InitializeComponent();

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            if (e.NavigationMode == NavigationMode.New)
            {
                string ans = null;
                NavigationContext.QueryString.TryGetValue("dictation", out ans);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (question.Text == "")
            {
                
                response.Text = "You must ask me a question first";
            }

            else
            {
                string[] responses =
                {
                    "It is certain", "It is decidedly so", "Without a doubt", "Yes", "Nahhhh",
                    "No way", "You serious!?", "Yes you may rely on it", "Outlook good", "Ask again later",
                    "Cannot predict now",
                    "That could work"
                };


                response.Text = responses[new Random().Next(0, responses.Length)];
            }
        }

        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}