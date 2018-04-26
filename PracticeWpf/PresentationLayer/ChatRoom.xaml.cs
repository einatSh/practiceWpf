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

namespace PracticeWpf.PresentationLayer
{
    /// <summary>
    /// Interaction logic for ChatRoom.xaml
    /// </summary>
    public partial class ChatRoom : Page
    {
        public ChatRoom()
        {
            InitializeComponent();
        }

        private void messageSent(object sender, TextChangedEventArgs e)
        {

        }

        private void send(object sender, RoutedEventArgs e)
        {
            
        }

        private void about(object sender, RoutedEventArgs e)
        {

        }

        private void optionBtn(object sender, RoutedEventArgs e)
        {
            optionFrame.Content = new optionsMenu();
        }

        private void optionFrame_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}
