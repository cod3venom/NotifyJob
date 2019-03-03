using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;
using System.Drawing.Drawing2D;

namespace NotifyJob___UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //there i can access UserControls 
            //this.WindowState = FormWindowState.Maximized;
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(profilebox.DisplayRectangle);
            profilebox.Region = new Region(gp);

            gp.AddEllipse(closeBTN.DisplayRectangle);
            closeBTN.Region = new Region(gp);
        }
        public string NotificationsID
        {
      
            get { return countNotification.Text; }
            set { countNotification.Text = value; }
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            //remove 

          

            //
            Thread writeCOnf = new Thread(new ThreadStart(() => Confs.vars.makeFile()));
            writeCOnf.Start();
            if (File.Exists(Confs.vars.linksfile))
            {
                   
                  NotificationsID = Confs.vars.countLinks().ToString();
                if (NotificationsID != "0")
                {
                    countNotification.ForeColor = Color.Red;
                }
            }
        }
        public ListBox skillbox;
        private void Form1_Load(object sender, EventArgs e)
        {
            this.AutoSize = true;

              scrapeData("https://useme.eu/pl/jobs/");
        }
        bool ishutDown = false;
        public void scrapeData(string page)
        {
           
            
                            var web = new HtmlWeb();
                            var doc = web.Load(page);
                            var articles = doc.DocumentNode.SelectNodes("//*[@class='wrapper']");
                            foreach (var article in articles)
                            {

                                // var header =article.SelectNodes("//*[@id=\"job-list\"]/div[*]/div[*]/div/h2/a"); works perfectly 1
                                //var header = article.SelectNodes("//*[@id=\"job-list\"]/div[1]/div[2]/div/div[2]");
                                var header = article.SelectNodes("//*[@id=\"job-list\"]/div[*]/div[*]/div/h2/a");
                                string data = article.InnerText;
                                string debug = article.InnerText;
                                debug = Regex.Replace(debug, @"[\d -]", " ");
                                var link = article.Descendants("a").ToList()[0].GetAttributeValue("href", null); //there i can get the url 
                                                                                                                 //for special item



                                var subText = debug.Substring(debug.IndexOf("a:") + 73);//should +73 length byte to remove whitespaces

                                data = data.Replace("budżet:", "/");
                                string[] spliter = Regex.Split(data, "/");

                                subText = string.Join(" ", subText.ToString().Split().Where(x => x != ""));
                                string title = spliter[0].ToString();
                                title = title.TrimEnd();
                                title = title.TrimStart();

                                string budget = "Cena : " + spliter[1].ToString();
                                budget = string.Join(" ", budget.ToString().Split().Where(x => x != ""));


                                string date = spliter[2].ToString();
                                date = string.Join(" ", date.ToString().Split().Where(x => x != ""));
                                date = date.TrimEnd();
                                date = date.TrimStart();
                                string endDate = spliter[3].ToString();
                                endDate = string.Join(" ", endDate.ToString().Split().Where(x => x != ""));
                                endDate = endDate.TrimEnd();
                                endDate = endDate.TrimStart();
                                string[] endsplit = Regex.Split(endDate, " ");
                               
                            jobOffer _job = new jobOffer();
                                     _job.titlelabel.Text = title;
                                    _job.budget.Text = budget;
                                    _job.date.Text = date;
                                    _job.enddate.Text = endsplit[0].ToString() + endsplit[1].ToString();
                                    _job.url.Text = "https://useme.eu" + link;
                                    _job.descriptionlabel.Text = subText.ToString() + "\n";
                                   _job.Dock = DockStyle.Top;
                                   categoryPanel.Controls.Add(_job);
            
                categoryPanel.AutoScroll = false;
                categoryPanel.HorizontalScroll.Enabled = false;
                categoryPanel.AutoScroll = true;
                 

            }
        }

         
        private bool CheckForm(Form form)
        {
            form = Application.OpenForms[form.Text];
            if (form != null)
                return true;
            else
                return false;
        }
       

       
        private void categoriesBTN_Click(object sender, EventArgs e)
        {
            
        }

        private void userOptions_MouseClick(object sender, MouseEventArgs e)
        {

            //if (e.Button == MouseButtons.Left)
            //{
            //    userMenu.Show(userOptions, new Point(10, 30));

            //}

        }

        private void userOptions_Click(object sender, EventArgs e)
        {

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

        private void minBTN_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void closeBTN_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void searchText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //categoryPanel.Dispose();
                //categoryPanel.Controls.Clear();
                scrapeData("https://useme.eu/pl/jobs/?query=" + searchText.Text + "&order_by=-published_on");
            }
        }

        private void platforomsBTN_Click(object sender, EventArgs e)
        {
            TabControl _ctrl = new TabControl();
            _ctrl.Name = "PlatCtrl";
            _ctrl.Dock= DockStyle.Fill;
           
            _ctrl.Controls.Add(new TabPage()
            {

                Name = "PlatformsPage",
                Dock = DockStyle.Top

            });
            platformsUi _platforms = new platformsUi();
            _platforms.freelancebtn.Click += new EventHandler(click_freelance);
             _ctrl.TabPages["PlatformsPage"].Controls.Add(_platforms);
            categoryPanel.Controls.Clear();
            categoryPanel.Controls.Add(_ctrl);
        }

        private void click_freelance(object sender, EventArgs e)
        {
            Thread _emulator = new Thread(() =>Confs.ie_helper.WebBrowserHelper.GetBrowserEmulationMode());
            _emulator.Start();
            TabControl _ctrl = new TabControl();
            _ctrl.Name = "freeLancer";
            _ctrl.Dock = DockStyle.Fill;
            _ctrl.Controls.Add(new TabPage()
            {

                Name = "Freelancer",
                Text="Freelancer.com please log in",
                Dock = DockStyle.Top

            });

            WebBrowser _Wb = new WebBrowser();
            _Wb.Dock = DockStyle.Fill;
            _Wb.ScriptErrorsSuppressed = true;
            _ctrl.TabPages["Freelancer"].Controls.Add(_Wb);
            _Wb.Navigate("http://freelancer.com/");
            categoryPanel.Controls.Clear();
            categoryPanel.Controls.Add(_ctrl);
            
        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            categoryPanel.Controls.Clear();
            scrapeData("https://useme.eu/pl/jobs/");
        }

        private void TasksBtn_Click(object sender, EventArgs e)
        {
            Thread RealTime = new Thread(() => Confs.realtime.realtimeScrapping("https://useme.eu/pl/jobs/", this));
            RealTime.Start();
            TabControl _ctrl = new TabControl();
            _ctrl.Dock = DockStyle.Fill;
            _ctrl.Controls.Add(new TabPage()
            {

                Name = "Tasks",
                Text= "Task Settings",
                BackColor= Color.White,
                Dock = DockStyle.Fill

            });
            Tasks _taskWindow = new Tasks();
             _ctrl.TabPages["Tasks"].Controls.Add(_taskWindow);
            categoryPanel.Controls.Clear();
            categoryPanel.Controls.Add(_ctrl);
           
        }

        private void categoryPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        public static bool IsEven(int value) //getting Items TItle
        {
            return value % 2 == 0;
        }
        public static bool IsOdd(int value)//getting items link
        {
            return value % 2 != 0;
        }
        public void notifBTN_Click(object sender, EventArgs e)
        {
            showNewNotificaitonsPage();
            
        }

        public void showNewNotificaitonsPage()
        {
           
            UInewNotif[] _notifitem = new UInewNotif[9];
            TabControl _ctrl = new TabControl();
            _ctrl.Dock = DockStyle.Fill;
            _ctrl.Controls.Add(new TabPage()
            {

                Name = "Notifications",
                Text = "New Notifications " + NotificationsID,
                BackColor = Color.White,
                Dock = DockStyle.Top

            });
            try
            {
                Label[] _lbl = new Label[50];
                string link = Confs.realtime.notifications_toList();
                string item = Confs.realtime.notifications_toList();//titles
                item = item.Replace("@", "");
                item = item.Replace("#", "");
                string[] SKILL = Regex.Split(link, "#");
                
                

                for (int i = 1; i <= 100; i++)
                {
                    if (IsEven(i))
                    {
                        _lbl[i] = new Label();
                       
                        item = item.Replace(SKILL[i].ToString(), "");
                        string[] SELECTitem = Regex.Split(item, "!");
                        _lbl[i].Text = SELECTitem[i].ToString();
                        _lbl[i].Dock = DockStyle.Top;


                        _notifitem[i] = new UInewNotif();
                        _notifitem[i].Dock = DockStyle.Top;
                        _notifitem[i].SKill = SKILL[i].ToString();
                        _notifitem[i].Title = _lbl[i].Text;
                        _notifitem[i].Link = SELECTitem[i - 1].ToString();
                       
                         _ctrl.TabPages["Notifications"].Controls.Add(_notifitem[i]);
                        categoryPanel.Controls.Clear();
                        categoryPanel.Controls.Add(_ctrl);

                    }
                }
                NotificationsID = "0";
            }
            catch { }


        }

        private void settingsBTN_Click(object sender, EventArgs e)
        {
            userProfile _profile = new userProfile();
            try
            {
                TabControl _ctrl = new TabControl();
                _ctrl.Dock = DockStyle.Fill;
                _ctrl.Controls.Add(new TabPage()
                {

                    Name = "Settings",
                    Text = "Settings ",
                    BackColor = Color.White,
                    Dock = DockStyle.Top

                });
                _ctrl.TabPages["Settings"].Controls.Add(_profile);
                categoryPanel.Controls.Clear();
                categoryPanel.Controls.Add(_ctrl);
            }
            catch { }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
          
        }

       
    }
}
