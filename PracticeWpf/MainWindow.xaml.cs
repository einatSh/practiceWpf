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
using PracticeWpf.Logger;

namespace PracticeWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            
            Log.Instance.debug("Debugged successfully");//log
            Log.Instance.info("Chat Room initiated successfully");//log
            InitializeComponent();
            media.Play();
            Main.Content = new MainScreen();
            this.Closed += closed; //add evant to Closed
        }

        //If program is closed
        private void closed(object sender, System.EventArgs e)
        {
            Log.Instance.info("Chat Room closed - logged out and exit system");//log
            this.Close();
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

        private void Window_Closed(object sender, EventArgs e)
        {

        }
    }
}
