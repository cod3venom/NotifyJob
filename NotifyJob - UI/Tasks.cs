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
    public partial class Tasks : UserControl
    {
        public Tasks()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            taskTimer.Items.Add(5);
            taskTimer.Items.Add(20);
            taskTimer.Items.Add(40);
            taskTimer.Items.Add(60);
            taskTimer.SelectedIndex = 1;
        }
        private void Tasks_Load(object sender, EventArgs e)
        {

        }
    }
}
