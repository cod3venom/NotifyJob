using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;

namespace NotifyJob___UI.uiActions
{
 
    public partial class alert : Form
    {
        private SoundPlayer _notifywav;
        int slideheight;
        bool hidden;
        public string title;
        public string budget;
        public string date;
        public string enddate;
        public string descr;
        public alert()
        {
            InitializeComponent();
            this.ShowInTaskbar = false;
            _notifywav = new SoundPlayer("ring.wav");
            slideheight = this.Width;
            hidden = false;
        }
         
        private void slidingTime_Tick(object sender, EventArgs e)
        {
            if (hidden)
            {
                this.Height = this.Height + 10;
                if (this.Height >= slideheight)
                {
                    
                    //slidingTime.Stop();
                    //hidden = false;
                    //  this.Close();

                }
            }
            else
            {
                this.Height = this.Height - 10;
                this.Close();
                if (this.Height <= 0)
                {
                    //slidingTime.Stop();
                    ////hidden = true;
                    ////this.Close();
                }

            }
        }
        
        private void alert_Load(object sender, EventArgs e)
        {

 
                //MessageBox.Show(news.ToString());
            _notifywav.Play();

             
                slidingTime.Start();
            }

        private void maxminBTN_Click(object sender, EventArgs e)
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

        private void closeBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

