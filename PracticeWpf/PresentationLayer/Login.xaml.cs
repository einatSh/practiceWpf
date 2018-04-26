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
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        public Login()
        {
            InitializeComponent();
        }

        private void about(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Login screen (a place where login stuff happen)");
        }

        private void g_idChange(object sender, TextChangedEventArgs e)
        {

        }

        private void nicknameChange(object sender, TextChangedEventArgs e)
        {

        }

        private void send(object sender, RoutedEventArgs e)
        {
            NavigationService.GetNavigationService(this).Navigate(new ChatRoom());
        }
    }
}
