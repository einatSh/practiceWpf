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
using PracticeWpf.CustumeForms;


namespace PracticeWpf.PresentationLayer
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        private string name;
        private string id;
        private int failedAtmpt;

        public Login()
        {
            InitializeComponent();
            name = null;
            id = null;
            failedAtmpt = 0;
        }

        private void about(object sender, RoutedEventArgs e)
        {
            messageBox.show("Login screen (a place where login stuff happen)");
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
            if (name == null || id == null || int.Parse(id) <= 0 || int.Parse(id) >= 100)
            {
               
                
                messageBox.show("SHAME! \nInvalid input - please note that the feilds can't remain empty \nand id can be between 1 to 99!");
                failedAtmpt++;

                if (failedAtmpt == 3)
                {
                    videoBox.show();
                    failedAtmpt = 0;
                }
            }
            else
                NavigationService.GetNavigationService(this).Navigate(new ChatRoom());
        }
    }
}
