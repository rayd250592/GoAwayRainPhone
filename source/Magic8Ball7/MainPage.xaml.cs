using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace Magic8Ball7
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (question.Text == "")
            {

                response.Text = "You must ask me a question first";

            }

            else
            {



                string[] responses = { "It is certain", "It is decidedly so", "Without a doubt", "Yes", "Nahhhh",
                                     "No way", "You serious!?", "Yes you may rely on it", "Outlook good", "Ask again later", "Cannot predict now",
                                 "That could work"};


                response.Text = responses[new Random().Next(0, responses.Length)];


            }
        }
    }
}