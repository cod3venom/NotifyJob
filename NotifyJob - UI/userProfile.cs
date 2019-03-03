using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotifyJob___UI
{
    public partial class userProfile : UserControl
    {
        public userProfile()
        {
            InitializeComponent();
        }

        private void MailCH_CheckedChanged(object sender, EventArgs e)
        {
            if (MailCH.Checked)
            {
                ChangePWD.Checked = false;
                passTXT.Visible = false;
                changePasLBL.Visible = false;
                changeMailLBL.Visible = true;
                mailtxt.Visible = true;
                mailtxt.Location = new Point(166, 303);
            }
        }

        private void ChangePWD_CheckedChanged(object sender, EventArgs e)
        {
            if (ChangePWD.Checked)
            {
                MailCH.Checked = false;
                passTXT.Visible = true;
                passTXT.Location = new Point(166, 303);
                changePasLBL.Location = new Point(70, 308);
                changePasLBL.Visible = true;
                changeMailLBL.Visible = false;
                mailtxt.Visible = false;
            }
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            changeMailLBL.Visible = false;
            changePasLBL.Visible = false;
            mailtxt.Visible = false;
            passTXT.Visible = false;
        }
        private void userProfile_Load(object sender, EventArgs e)
        {
           
        }
    }
}
