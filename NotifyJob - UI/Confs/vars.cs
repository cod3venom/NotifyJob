using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotifyJob___UI.Confs
{
    class vars
    {
         
         public static bool isShutDown = false;
 
        public static string notificationsFile = DateTime.Now.ToString("yyyyMMdd") + ".HTML";

        public static string notifsDir = Environment.CurrentDirectory + @"\nots\";
        public static string linksfile = notifsDir + @"\" + DateTime.Now.ToString("yyyyMMdd") + "_links.txt";
        public static string full = notifsDir + notificationsFile;
        public static void makeFile()
        {
            
            if (!Directory.Exists(notifsDir))
            {
                Directory.CreateDirectory(notifsDir);
               
            }
            if (Directory.Exists(notifsDir))
            {
                if (!File.Exists(full ))
                {
                    File.WriteAllText(full, "");
                }
                if (!File.Exists(linksfile))
                {
                    File.WriteAllText(linksfile, "");
                }
            }
        }

        public static void Writenots(string file, string doc)
        {
            if (!File.Exists(file))
            {
                Thread writeCOnf = new Thread(new ThreadStart(() => Confs.vars.makeFile()));
                writeCOnf.Start();
            }
            if (File.Exists(file))
            {
                File.AppendAllText(file,  doc + Environment.NewLine);
 
            }
        }
        
        public static string  readfile(string file)
        {
            if (File.Exists(file))
            {
                string db = File.ReadAllText(file);
                return db;
            }
            if (!File.Exists(file))
            {
                Thread writeCOnf = new Thread(new ThreadStart(() => Confs.vars.makeFile()));
                writeCOnf.Start();
                string db = File.ReadAllText(file);
                return db;
            }
            return "nothing";
        }
        public static int countLinks()
        {
            var number = Regex.Matches(readfile(linksfile).ToString(), "[@]").Count;
            int count = Convert.ToInt32(number);
            return count;
        }
    }
}
