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
using PracticeWpf.BusinessLayer;
using PracticeWpf.Logger;

namespace PracticeWpf.PresentationLayer
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        private string name;
        private string id;

        public Login()
        {
            InitializeComponent();
            name = null;
            id = null;
        }

        private void about(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Login screen (a place where login stuff happen)");
        }

        private void g_idChange(object sender, TextChangedEventArgs e)
        {
            id = Id.Text;
        }

        private void nicknameChange(object sender, TextChangedEventArgs e)
        {
            name = Name.Text;
        }

        private void send(object sender, RoutedEventArgs e)
        {
            //no input in one or more fields
            if(name == null || id == null)
            {
                MessageBox.Show("Invalid input - please note that the feilds can't remain empty!");
            }
            else
                NavigationService.GetNavigationService(this).Navigate(new ChatRoom());
        }
    }
}
