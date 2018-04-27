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
    /// Interaction logic for Registration.xaml
    /// </summary>
    public partial class Registration : Page
    {
        private char gender;
        private bool sendClicked;
        private string name;
        private string id;

        public Registration()
        {
            InitializeComponent();
            gender = 'n';
            sendClicked = false;
            name = null;
            id = null;
        }

        private void about(object sender, RoutedEventArgs e)
        {

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
            //if user or id is null throw some warning and add to counter

            sendClicked = true;

        }

        private void genderM(object sender, RoutedEventArgs e)
        {
            gender = 'm';
        }

        private void genderF(object sender, RoutedEventArgs e)
        {
            gender = 'f';
        }

        public char Gender
        {
            get { return gender; }
            set { }
        }
    }
}
