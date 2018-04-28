using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeWpf
{
    public partial class msgBox : Form
    {
        public msgBox()
        {
            InitializeComponent();
        }

        public Image msgIcon
        {
            get { return pictureBox1.Image; }
            set { pictureBox1.Image = value; }
        }

        public string Message
        {
            get { return msgContent.Text; }
            set { msgContent.Text = value; }
        }


    }
}
