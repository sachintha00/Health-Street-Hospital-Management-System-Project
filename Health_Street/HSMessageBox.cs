using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Health_Street
{
    public static class HSMessageBox
    {
        public static DialogResult Show(string Message, string Caption, MessageBoxButtons Button, MessageBoxIcon MessageBoxIcon)
        {
            DialogResult drslt = DialogResult.None;
            switch(Button)
            {
                case MessageBoxButtons.YesNo:
                    using (frmMessageQuestion frmQ = new frmMessageQuestion())
                    {
                        frmQ.Message = Message;
                        frmQ.Caption = Caption;
                        switch(MessageBoxIcon)
                        {
                            case MessageBoxIcon.Question:
                                frmQ.ImageBoxIcon = Health_Street.Properties.Resources.Question;
                                break;
                            case MessageBoxIcon.Error:
                                frmQ.ImageBoxIcon = Health_Street.Properties.Resources.Error;
                                break;
                        }
                        drslt = frmQ.ShowDialog();
                    }
                    break;
                case MessageBoxButtons.OK:
                    using (frmMessageError frmOk = new frmMessageError())
                    {
                        frmOk.Message = Message;
                        frmOk.Caption = Caption;
                        switch(MessageBoxIcon)
                        {
                            case MessageBoxIcon.Question:
                                frmOk.ImageBoxIcon = Health_Street.Properties.Resources.Question;
                                break;
                            case MessageBoxIcon.Error:
                                frmOk.ImageBoxIcon = Health_Street.Properties.Resources.Error;
                                break;
                        }
                        drslt = frmOk.ShowDialog();
                    }
                    break;
            }
            return drslt;
        }
    }
}
