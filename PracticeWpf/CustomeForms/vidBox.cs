using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeWpf.CustumeForms
{
    public partial class vidBox : Form
    {
        public vidBox()
        {
            InitializeComponent();
            axWindowsMediaPlayer1.URL = @"C:\Users\einat\source\repos\PracticeWpf\PracticeWpf\Media\Video and Gif\Family Guy Parodies Cersei’s Walk of Shame from Game of Thrones.mp4";
            axWindowsMediaPlayer1.settings.volume = 100;
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }


    }
}
