using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotifyJob___UI.Confs
{
    public partial class _browser : Form
    {
        public _browser()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            Thread _emulator = new Thread(() => ie_helper.WebBrowserHelper.GetBrowserEmulationMode());
            _emulator.Start();
        }
        public string Header
        {
            get { return headerLBL.Text; }
            set { headerLBL.Text = value; }
        }
        public  string url;
         
        
       
        public void _browser_Load(object sender, EventArgs e)
        {
            searchText.Text = url;
            web.Navigate(url);
           
        }

        public void closeBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void minBTN_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public void maxminBTN_Click(object sender, EventArgs e)
        {

            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                return;
            }
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                return;
            }
        }

        private void backArrow_Click(object sender, EventArgs e)
        {
            web.GoBack();
        }

        private void ForwardArrow_Click(object sender, EventArgs e)
        {
            web.GoForward();
        }

        private void web_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            web.Document.GetElementById("topmenu").InnerHtml = "<div id=\"topmenu\"" +
                " style=\"border-bottom-color: white;\">" +
                "<div class=\"row\"></div></div>";
            //web.Document.GetElementById("mobile-tree").InnerHtml = "";
            web.Document.GetElementById("breadcrumbs").InnerHtml = "";
            web.Document.GetElementById("footer-container").InnerHtml = string.Empty;
        }
    }
}
