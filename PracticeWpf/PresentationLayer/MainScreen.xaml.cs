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
    /// Interaction logic for MainScreen.xaml
    /// </summary>
    public partial class MainScreen : Page
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void about(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Info101: This button is useless, \n" +
                "I put it here for no reason at all " +
                "But we will keep it here forever and ever");
        }

        private void Registeration(object sender, RoutedEventArgs e)
        {
            NavigationService.GetNavigationService(this).Navigate(new Registration());
        }

        private void Login(object sender, RoutedEventArgs e)
        {
            NavigationService.GetNavigationService(this).Navigate(new Login());
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
