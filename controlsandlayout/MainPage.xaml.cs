using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace controlsandlayout
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void messageButton_Click(object sender, RoutedEventArgs e)
        {
            string name = "Xaml is cool and good.";
            int x = 3;
            x *= 17;
            double d = Math.PI / 2;
            myTextBlock.Text = name + " x is: " + x + " d is: " + d; //hopefully there's a better way to do this than string addition.
            myTextBlock.Visibility = Visibility.Visible;
        }

        private void ifNElseButton_Click(object sender, RoutedEventArgs e)
        {
            int x = 5;
            if(x == 10)
            {
                myTextBlock.Text = "X is equal to 10";
                myTextBlock.Visibility = Visibility.Visible;
            }
            else
            {
                myTextBlock.Text = "X is equal to " + x + " not 10";
                myTextBlock.Visibility = Visibility.Visible;
            }
            
        }

        private void conditionalTest_Click(object sender, RoutedEventArgs e)
        {
            int someValue = 4;
            string name = "Bob";
            if ((someValue == 3) || (name == "Bob"))
            {
                myTextBlock.Text = "The name was Bob, but someValue = " + someValue;
                myTextBlock.Visibility = Visibility.Visible;
            }
        }

        private void loopButton_Click(object sender, RoutedEventArgs e)
        {
            int count = 0;
            myTextBlock.Visibility = Visibility.Visible;
            while(count < 10)
            {
                count += 1;
                myTextBlock.Text = count.ToString();
            }
            for (int i = 0; i < 20; i++)
            {
                count -= 1;
                myTextBlock.Text = count.ToString();
            }
        }
    }
}
