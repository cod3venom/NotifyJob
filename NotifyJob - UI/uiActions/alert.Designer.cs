namespace NotifyJob___UI.uiActions
{
    partial class alert
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(alert));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.dismisPanel = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.maxminBTN = new Bunifu.Framework.UI.BunifuImageButton();
            this.closeBTN = new Bunifu.Framework.UI.BunifuImageButton();
            this.slidingTime = new System.Windows.Forms.Timer(this.components);
            this.jobOffer1 = new NotifyJob___UI.jobOffer();
            this.dragalert = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.dismisPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxminBTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBTN)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // dismisPanel
            // 
            this.dismisPanel.BackColor = System.Drawing.Color.White;
            this.dismisPanel.Controls.Add(this.panel11);
            this.dismisPanel.Controls.Add(this.maxminBTN);
            this.dismisPanel.Controls.Add(this.closeBTN);
            this.dismisPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.dismisPanel.Location = new System.Drawing.Point(0, 0);
            this.dismisPanel.Name = "dismisPanel";
            this.dismisPanel.Size = new System.Drawing.Size(530, 33);
            this.dismisPanel.TabIndex = 7;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(530, 5);
            this.panel11.TabIndex = 67;
            // 
            // maxminBTN
            // 
            this.maxminBTN.BackColor = System.Drawing.Color.White;
            this.maxminBTN.Image = ((System.Drawing.Image)(resources.GetObject("maxminBTN.Image")));
            this.maxminBTN.ImageActive = null;
            this.maxminBTN.Location = new System.Drawing.Point(28, 12);
            this.maxminBTN.Name = "maxminBTN";
            this.maxminBTN.Size = new System.Drawing.Size(15, 15);
            this.maxminBTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.maxminBTN.TabIndex = 14;
            this.maxminBTN.TabStop = false;
            this.maxminBTN.Zoom = 10;
            this.maxminBTN.Click += new System.EventHandler(this.maxminBTN_Click);
            // 
            // closeBTN
            // 
            this.closeBTN.BackColor = System.Drawing.Color.White;
            this.closeBTN.Image = ((System.Drawing.Image)(resources.GetObject("closeBTN.Image")));
            this.closeBTN.ImageActive = null;
            this.closeBTN.Location = new System.Drawing.Point(12, 12);
            this.closeBTN.Name = "closeBTN";
            this.closeBTN.Size = new System.Drawing.Size(15, 15);
            this.closeBTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeBTN.TabIndex = 13;
            this.closeBTN.TabStop = false;
            this.closeBTN.Zoom = 10;
            this.closeBTN.Click += new System.EventHandler(this.closeBTN_Click);
            // 
            // slidingTime
            // 
            this.slidingTime.Interval = 10000;
            this.slidingTime.Tick += new System.EventHandler(this.slidingTime_Tick);
            // 
            // jobOffer1
            // 
            this.jobOffer1.AutoSize = true;
            this.jobOffer1.BackColor = System.Drawing.Color.White;
            this.jobOffer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.jobOffer1.ForeColor = System.Drawing.Color.Gray;
            this.jobOffer1.Location = new System.Drawing.Point(0, 33);
            this.jobOffer1.Name = "jobOffer1";
            this.jobOffer1.Size = new System.Drawing.Size(530, 146);
            this.jobOffer1.TabIndex = 8;
            this.jobOffer1.Title = "title";
            // 
            // dragalert
            // 
            this.dragalert.Fixed = true;
            this.dragalert.Horizontal = true;
            this.dragalert.TargetControl = this.jobOffer1;
            this.dragalert.Vertical = true;
            // 
            // alert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(530, 179);
            this.Controls.Add(this.jobOffer1);
            this.Controls.Add(this.dismisPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "alert";
            this.Text = "alert";
            this.Load += new System.EventHandler(this.alert_Load);
            this.dismisPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.maxminBTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBTN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel dismisPanel;
        private System.Windows.Forms.Panel panel11;
        private Bunifu.Framework.UI.BunifuImageButton maxminBTN;
        private Bunifu.Framework.UI.BunifuImageButton closeBTN;
        private System.Windows.Forms.Timer slidingTime;
        public jobOffer jobOffer1;
        private Bunifu.Framework.UI.BunifuDragControl dragalert;
    }
}