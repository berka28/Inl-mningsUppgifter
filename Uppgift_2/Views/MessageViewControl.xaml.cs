using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Uppgift_2.Views
{
    /// <summary>
    /// Interaction logic for MessageViewControl.xaml
    /// </summary>
    public partial class MessageViewControl : UserControl
    {
        public MessageViewControl()
        {
            InitializeComponent();
        }

        private void messageButton1_Click(object sender, RoutedEventArgs e)
        {
            subject.Text = "Subject of the message";
            from.Text = "Webmastern <webmastern@home.com>";
            to.Text = "Mathias Berquist";
            body1.Text = "Testar här då";        }

        private void messageButton2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void messageButton3_Click(object sender, RoutedEventArgs e)
        {

        }

        private void messageButton4_Click(object sender, RoutedEventArgs e)
        {

        }

        private void messageButton5_Click(object sender, RoutedEventArgs e)
        {

        }

        private void messageButton6_Click(object sender, RoutedEventArgs e)
        {

        }

        private void messageButton7_Click(object sender, RoutedEventArgs e)
        {

        }

        private void messageButton8_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
