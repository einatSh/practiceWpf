using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeWpf.CustumeForms
{
    class videoBox
    {
        public static System.Windows.Forms.DialogResult show()
        {
            System.Windows.Forms.DialogResult dialogResult = System.Windows.Forms.DialogResult.None;
            using(vidBox vb = new vidBox())
            {
                
                dialogResult = vb.ShowDialog();
            }
            return dialogResult;
        }
    }
}
