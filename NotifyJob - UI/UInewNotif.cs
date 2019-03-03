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
    public partial class UInewNotif : UserControl
    {
        public UInewNotif()
        {
            InitializeComponent();
        }
        public string Title
        {
            get { return titlelabel.Text; }
            set { titlelabel.Text = value; }
        }
        public string Link
        {
            get { return linklabel.Text; }
            set { linklabel.Text=value; }
        }
        public string SKill
        {
            get { return skillLabel.Text; }
            set { skillLabel.Text = value; }
        }
        public void UInewNotif_Load(object sender, EventArgs e)
        {
            this.notsBasiCPanel.BackColor = Color.FromArgb(66, 103, 178);
            this.titlelabel.BackColor= Color.FromArgb(66, 103, 178);
            this.titlelabel.ForeColor = Color.White;
            this.skillLabel.BackColor= Color.FromArgb(66, 103, 178);
            this.skillLabel.ForeColor= Color.White;
            this.linklabel.BackColor = Color.FromArgb(66, 103, 178);
            this.linklabel.ForeColor = Color.FromArgb(66, 103, 178);
        }

        public void showBTN_Click(object sender, EventArgs e)
        {
            showNewNotification();
        }
       
        
        public void showNewNotification()
        {
            this.notsBasiCPanel.BackColor = Color.White;
            this.titlelabel.BackColor = Color.White;
            this.titlelabel.ForeColor = Color.DimGray;
            this.skillLabel.BackColor = Color.White;
            this.skillLabel.ForeColor = Color.DimGray;
            this.linklabel.BackColor = Color.White;
            this.linklabel.ForeColor = Color.White;
            this.showBTN.BackColor = Color.White;
            this.showBTN.Normalcolor = Color.White;
            this.showBTN.ForeColor = Color.DimGray;
            Confs._browser _browser = new Confs._browser();
            if (_browser.IsDisposed)
            {
                _browser = new Confs._browser();
                _browser.url = Link;
                _browser.Header = Title;
                _browser.Show();
            }
            _browser.url = Link;
            _browser.Header = Title;
            _browser.Show();
        }

        private void notsBasiCPanel_Click(object sender, EventArgs e)
        {
            showNewNotification();
        }
    }
}
