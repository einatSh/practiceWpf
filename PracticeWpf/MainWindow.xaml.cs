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
using PracticeWpf.PresentationLayer;

namespace PracticeWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            media.Play();
            Main.Content = new MainScreen();
        }

        private void musicOn(object sender, RoutedEventArgs e)
        {
            media.Play();
        }

        private void musicOff(object sender, RoutedEventArgs e)
        {
            media.Stop();
        }

        private void Main_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}
