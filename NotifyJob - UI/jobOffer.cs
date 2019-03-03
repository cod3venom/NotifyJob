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
    public partial class jobOffer : UserControl
    {
        public jobOffer()
        {
            InitializeComponent();
        }
        public string Title
        {
            get { return titlelabel.Text; }
            set { titlelabel.Text = value; }
        }
        private void jobOffer_Load(object sender, EventArgs e)
        {

        }

        private void viewBTN_Click(object sender, EventArgs e)
        {
           Confs._browser _browser = new Confs._browser();
            if (_browser.IsDisposed)
            {
                _browser = new Confs._browser();
                _browser.url = url.Text;
                _browser.Show();
            }
            _browser.url = url.Text;
            _browser.Show();
        }
    }
}
