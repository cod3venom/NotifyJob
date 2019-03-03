using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotifyJob___UI.Confs
{
    class realtime
    {
        public static bool isShutDown = false;
        public static string linkHref = "";
        public static ListBox lb = new ListBox();
        public static string title;
        public static Form1 frm = new Form1();
        public static void realtimeScrapping(string page, Form1 frm)
        {
            
            string[] skills = { "SEO", "HTML5", "photoshop", "filmu", "video", "OPINII", "mongodb" };
            while (!isShutDown)
            {
                if (isShutDown) { break; }

                foreach (string lang in skills)
                {

                    var web = new HtmlWeb();
                    var doc = web.Load(page);
                    var articles = doc.DocumentNode.SelectNodes("//*[@class='wrapper']");
                    foreach (var article in articles)
                    {
                        if (article.InnerText.Contains(lang))
                        {
                            var header = article.SelectNodes("//*[@id=\"job-list\"]/div[*]/div[*]/div/h2/a");
                            string data = article.InnerText;
                            string debug = article.InnerText;
                            debug = Regex.Replace(debug, @"[\d -]", " ");
                            var link = article.Descendants("a").ToList()[0].GetAttributeValue("href", null); //there i can get the url 
                            var subText = debug.Substring(debug.IndexOf("a:") + 73);//should +73 length byte to remove whitespaces
                            data = data.Replace("budżet:", "/");
                            string[] spliter = Regex.Split(data, "/");
                            subText = string.Join(" ", subText.ToString().Split().Where(x => x != ""));
                          title = spliter[0].ToString();
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

                            //if (!lb.Items.Contains(title))
                            //{
                            if (File.Exists(vars.full))
                            {
                                if (!Confs.vars.readfile(vars.full).ToString().Contains(title))
                                {
                                    linkHref = link.ToString();

                                    if (!Confs.vars.readfile(vars.linksfile).ToString().Contains(linkHref))
                                    {
                                        
                                            Confs.vars.Writenots(vars.linksfile,  "#!@https://useme.eu" + linkHref 
                                                + "!" +title +"#"+lang);
                                        


                                    }
                                    
                                        frm.countNotification.ForeColor = Color.Red;
                                        frm.NotificationsID = vars.countLinks().ToString();
                                   
                                    string dateend = endsplit[0].ToString() + endsplit[1].ToString();
                                    Confs.vars.Writenots(vars.full,"_" + title);
                                    frm.tray.BalloonTipIcon = ToolTipIcon.Info;
                                     frm.tray.BalloonTipClicked += new EventHandler(notif_clicked);
                                    frm.tray.BalloonTipText = subText.ToString();
                                    frm.tray.BalloonTipTitle = title;
                                    frm.tray.Click += new EventHandler(on_tray_click);
                                    frm.tray.ShowBalloonTip(60);
                                     //title = null;
                                    //endDate = null;
                                    //budget = null;
                                    //date = null;
                                    //subText = null;


                                }

                            }
                            if (!File.Exists(vars.full))
                            {
                                 Confs.vars.makeFile();
                                break;
                            }
                        }
                    }
                }
            }
        }
        public static string notifications_toList()
        {
            string[] _notifications = { vars.readfile(vars.linksfile).ToString() };
            List<string> nots = _notifications.ToList();
            string result = "";
            foreach (string item in nots)
            {
                result= item;
            }
            return result;
        }
        private static void notif_clicked(object sender, EventArgs e)
        {
            
                    NotifyIcon notify = sender as NotifyIcon;
                  string title = notify.Text;
                 
        }

        private static void on_tray_click(object sender, EventArgs e)
        {
            MessageBox.Show(title);
        }
    }
}
