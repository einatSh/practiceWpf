using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeWpf.CustumeForms
{
    class messageBox
    {
        public static System.Windows.Forms.DialogResult show(string msg)
        {
            System.Windows.Forms.DialogResult dialogResult = System.Windows.Forms.DialogResult.None;
            using(msgBox mb = new msgBox())
            {
                mb.Message = msg;
                mb.msgIcon = PracticeWpf.Properties.Resources.if_Info_32687;
                dialogResult = mb.ShowDialog();
            }

            return dialogResult;
        }
    }
}
