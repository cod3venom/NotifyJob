namespace NotifyJob___UI
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dragUp = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.homeElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.dragSidebar = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.sidebar = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.settingsBTN = new Bunifu.Framework.UI.BunifuFlatButton();
            this.TasksBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.platforomsBTN = new Bunifu.Framework.UI.BunifuFlatButton();
            this.profilebox = new Bunifu.Framework.UI.BunifuImageButton();
            this.homebtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.minBTN = new Bunifu.Framework.UI.BunifuImageButton();
            this.userLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.maxminBTN = new Bunifu.Framework.UI.BunifuImageButton();
            this.closeBTN = new Bunifu.Framework.UI.BunifuImageButton();
            this.jobBoardPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.categoryPanel = new System.Windows.Forms.Panel();
            this.countNotification = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.notifBTN = new Bunifu.Framework.UI.BunifuImageButton();
            this.searchText = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tray = new System.Windows.Forms.NotifyIcon(this.components);
            this.gradientTop = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minBTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxminBTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBTN)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.notifBTN)).BeginInit();
            this.gradientTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // dragUp
            // 
            this.dragUp.Fixed = true;
            this.dragUp.Horizontal = true;
            this.dragUp.TargetControl = null;
            this.dragUp.Vertical = true;
            // 
            // homeElipse
            // 
            this.homeElipse.ElipseRadius = 17;
            this.homeElipse.TargetControl = this;
            // 
            // dragSidebar
            // 
            this.dragSidebar.Fixed = true;
            this.dragSidebar.Horizontal = true;
            this.dragSidebar.TargetControl = this.sidebar;
            this.dragSidebar.Vertical = true;
            // 
            // sidebar
            // 
            this.sidebar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sidebar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sidebar.BackgroundImage")));
            this.sidebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sidebar.Controls.Add(this.settingsBTN);
            this.sidebar.Controls.Add(this.TasksBtn);
            this.sidebar.Controls.Add(this.platforomsBTN);
            this.sidebar.Controls.Add(this.profilebox);
            this.sidebar.Controls.Add(this.homebtn);
            this.sidebar.Controls.Add(this.minBTN);
            this.sidebar.Controls.Add(this.userLabel);
            this.sidebar.Controls.Add(this.maxminBTN);
            this.sidebar.Controls.Add(this.closeBTN);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidebar.GradientBottomLeft = System.Drawing.Color.DeepPink;
            this.sidebar.GradientBottomRight = System.Drawing.Color.BlueViolet;
            this.sidebar.GradientTopLeft = System.Drawing.Color.Blue;
            this.sidebar.GradientTopRight = System.Drawing.SystemColors.WindowText;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Name = "sidebar";
            this.sidebar.Quality = 10;
            this.sidebar.Size = new System.Drawing.Size(228, 543);
            this.sidebar.TabIndex = 75;
            // 
            // settingsBTN
            // 
            this.settingsBTN.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.settingsBTN.BackColor = System.Drawing.Color.Transparent;
            this.settingsBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.settingsBTN.BorderRadius = 0;
            this.settingsBTN.ButtonText = "                    Settings";
            this.settingsBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingsBTN.DisabledColor = System.Drawing.Color.Gray;
            this.settingsBTN.Iconcolor = System.Drawing.Color.Transparent;
            this.settingsBTN.Iconimage = ((System.Drawing.Image)(resources.GetObject("settingsBTN.Iconimage")));
            this.settingsBTN.Iconimage_right = null;
            this.settingsBTN.Iconimage_right_Selected = null;
            this.settingsBTN.Iconimage_Selected = null;
            this.settingsBTN.IconMarginLeft = 0;
            this.settingsBTN.IconMarginRight = 0;
            this.settingsBTN.IconRightVisible = false;
            this.settingsBTN.IconRightZoom = 0D;
            this.settingsBTN.IconVisible = false;
            this.settingsBTN.IconZoom = 90D;
            this.settingsBTN.IsTab = true;
            this.settingsBTN.Location = new System.Drawing.Point(0, 356);
            this.settingsBTN.Name = "settingsBTN";
            this.settingsBTN.Normalcolor = System.Drawing.Color.Transparent;
            this.settingsBTN.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.settingsBTN.OnHoverTextColor = System.Drawing.Color.White;
            this.settingsBTN.selected = false;
            this.settingsBTN.Size = new System.Drawing.Size(226, 38);
            this.settingsBTN.TabIndex = 72;
            this.settingsBTN.Text = "                    Settings";
            this.settingsBTN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingsBTN.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.settingsBTN.TextFont = new System.Drawing.Font("Segoe UI Light", 11.75F);
            this.settingsBTN.Click += new System.EventHandler(this.settingsBTN_Click);
            // 
            // TasksBtn
            // 
            this.TasksBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.TasksBtn.BackColor = System.Drawing.Color.Transparent;
            this.TasksBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TasksBtn.BorderRadius = 0;
            this.TasksBtn.ButtonText = "                    Tasks";
            this.TasksBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TasksBtn.DisabledColor = System.Drawing.Color.Gray;
            this.TasksBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.TasksBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("TasksBtn.Iconimage")));
            this.TasksBtn.Iconimage_right = null;
            this.TasksBtn.Iconimage_right_Selected = null;
            this.TasksBtn.Iconimage_Selected = null;
            this.TasksBtn.IconMarginLeft = 0;
            this.TasksBtn.IconMarginRight = 0;
            this.TasksBtn.IconRightVisible = false;
            this.TasksBtn.IconRightZoom = 0D;
            this.TasksBtn.IconVisible = false;
            this.TasksBtn.IconZoom = 90D;
            this.TasksBtn.IsTab = true;
            this.TasksBtn.Location = new System.Drawing.Point(0, 315);
            this.TasksBtn.Name = "TasksBtn";
            this.TasksBtn.Normalcolor = System.Drawing.Color.Transparent;
            this.TasksBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.TasksBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.TasksBtn.selected = false;
            this.TasksBtn.Size = new System.Drawing.Size(226, 38);
            this.TasksBtn.TabIndex = 71;
            this.TasksBtn.Text = "                    Tasks";
            this.TasksBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TasksBtn.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TasksBtn.TextFont = new System.Drawing.Font("Segoe UI Light", 11.75F);
            this.TasksBtn.Click += new System.EventHandler(this.TasksBtn_Click);
            // 
            // platforomsBTN
            // 
            this.platforomsBTN.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.platforomsBTN.BackColor = System.Drawing.Color.Transparent;
            this.platforomsBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.platforomsBTN.BorderRadius = 0;
            this.platforomsBTN.ButtonText = "                    Platforms";
            this.platforomsBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.platforomsBTN.DisabledColor = System.Drawing.Color.Gray;
            this.platforomsBTN.Iconcolor = System.Drawing.Color.Transparent;
            this.platforomsBTN.Iconimage = ((System.Drawing.Image)(resources.GetObject("platforomsBTN.Iconimage")));
            this.platforomsBTN.Iconimage_right = null;
            this.platforomsBTN.Iconimage_right_Selected = null;
            this.platforomsBTN.Iconimage_Selected = null;
            this.platforomsBTN.IconMarginLeft = 0;
            this.platforomsBTN.IconMarginRight = 0;
            this.platforomsBTN.IconRightVisible = false;
            this.platforomsBTN.IconRightZoom = 0D;
            this.platforomsBTN.IconVisible = false;
            this.platforomsBTN.IconZoom = 90D;
            this.platforomsBTN.IsTab = true;
            this.platforomsBTN.Location = new System.Drawing.Point(0, 274);
            this.platforomsBTN.Name = "platforomsBTN";
            this.platforomsBTN.Normalcolor = System.Drawing.Color.Transparent;
            this.platforomsBTN.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.platforomsBTN.OnHoverTextColor = System.Drawing.Color.White;
            this.platforomsBTN.selected = false;
            this.platforomsBTN.Size = new System.Drawing.Size(226, 38);
            this.platforomsBTN.TabIndex = 70;
            this.platforomsBTN.Text = "                    Platforms";
            this.platforomsBTN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.platforomsBTN.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.platforomsBTN.TextFont = new System.Drawing.Font("Segoe UI Light", 11.75F);
            this.platforomsBTN.Click += new System.EventHandler(this.platforomsBTN_Click);
            // 
            // profilebox
            // 
            this.profilebox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.profilebox.BackColor = System.Drawing.Color.Transparent;
            this.profilebox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profilebox.Image = ((System.Drawing.Image)(resources.GetObject("profilebox.Image")));
            this.profilebox.ImageActive = null;
            this.profilebox.Location = new System.Drawing.Point(76, 103);
            this.profilebox.Name = "profilebox";
            this.profilebox.Size = new System.Drawing.Size(89, 70);
            this.profilebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profilebox.TabIndex = 0;
            this.profilebox.TabStop = false;
            this.profilebox.Zoom = 7;
            // 
            // homebtn
            // 
            this.homebtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.homebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.homebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.homebtn.BorderRadius = 0;
            this.homebtn.ButtonText = "                     Home";
            this.homebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homebtn.DisabledColor = System.Drawing.Color.Gray;
            this.homebtn.Iconcolor = System.Drawing.Color.Transparent;
            this.homebtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("homebtn.Iconimage")));
            this.homebtn.Iconimage_right = null;
            this.homebtn.Iconimage_right_Selected = null;
            this.homebtn.Iconimage_Selected = null;
            this.homebtn.IconMarginLeft = 0;
            this.homebtn.IconMarginRight = 0;
            this.homebtn.IconRightVisible = false;
            this.homebtn.IconRightZoom = 0D;
            this.homebtn.IconVisible = false;
            this.homebtn.IconZoom = 90D;
            this.homebtn.IsTab = true;
            this.homebtn.Location = new System.Drawing.Point(0, 233);
            this.homebtn.Name = "homebtn";
            this.homebtn.Normalcolor = System.Drawing.Color.Transparent;
            this.homebtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.homebtn.OnHoverTextColor = System.Drawing.Color.White;
            this.homebtn.selected = true;
            this.homebtn.Size = new System.Drawing.Size(226, 38);
            this.homebtn.TabIndex = 0;
            this.homebtn.Text = "                     Home";
            this.homebtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homebtn.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.homebtn.TextFont = new System.Drawing.Font("Segoe UI Light", 11.75F);
            this.homebtn.Click += new System.EventHandler(this.homebtn_Click);
            // 
            // minBTN
            // 
            this.minBTN.BackColor = System.Drawing.Color.Transparent;
            this.minBTN.Image = ((System.Drawing.Image)(resources.GetObject("minBTN.Image")));
            this.minBTN.ImageActive = null;
            this.minBTN.Location = new System.Drawing.Point(35, 3);
            this.minBTN.Name = "minBTN";
            this.minBTN.Size = new System.Drawing.Size(15, 15);
            this.minBTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minBTN.TabIndex = 15;
            this.minBTN.TabStop = false;
            this.minBTN.Zoom = 10;
            this.minBTN.Click += new System.EventHandler(this.minBTN_Click);
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.BackColor = System.Drawing.Color.Transparent;
            this.userLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLabel.ForeColor = System.Drawing.Color.White;
            this.userLabel.Location = new System.Drawing.Point(81, 187);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(75, 21);
            this.userLabel.TabIndex = 69;
            this.userLabel.Text = "John Doe";
            this.userLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maxminBTN
            // 
            this.maxminBTN.BackColor = System.Drawing.Color.Transparent;
            this.maxminBTN.Image = ((System.Drawing.Image)(resources.GetObject("maxminBTN.Image")));
            this.maxminBTN.ImageActive = null;
            this.maxminBTN.Location = new System.Drawing.Point(19, 3);
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
            this.closeBTN.BackColor = System.Drawing.Color.Transparent;
            this.closeBTN.Image = ((System.Drawing.Image)(resources.GetObject("closeBTN.Image")));
            this.closeBTN.ImageActive = null;
            this.closeBTN.Location = new System.Drawing.Point(3, 3);
            this.closeBTN.Name = "closeBTN";
            this.closeBTN.Size = new System.Drawing.Size(15, 15);
            this.closeBTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeBTN.TabIndex = 13;
            this.closeBTN.TabStop = false;
            this.closeBTN.Zoom = 10;
            this.closeBTN.Click += new System.EventHandler(this.closeBTN_Click);
            // 
            // jobBoardPanel
            // 
            this.jobBoardPanel.AutoScroll = true;
            this.jobBoardPanel.AutoScrollMinSize = new System.Drawing.Size(5, 10);
            this.jobBoardPanel.Location = new System.Drawing.Point(130, 533);
            this.jobBoardPanel.Name = "jobBoardPanel";
            this.jobBoardPanel.Size = new System.Drawing.Size(853, 10);
            this.jobBoardPanel.TabIndex = 87;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(225)))), ((int)(((byte)(229)))));
            this.panel1.Controls.Add(this.sidebar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 543);
            this.panel1.TabIndex = 89;
            // 
            // categoryPanel
            // 
            this.categoryPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.categoryPanel.AutoScroll = true;
            this.categoryPanel.BackColor = System.Drawing.Color.White;
            this.categoryPanel.Location = new System.Drawing.Point(228, 60);
            this.categoryPanel.Name = "categoryPanel";
            this.categoryPanel.Size = new System.Drawing.Size(670, 483);
            this.categoryPanel.TabIndex = 90;
            this.categoryPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.categoryPanel_Paint);
            // 
            // countNotification
            // 
            this.countNotification.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.countNotification.AutoSize = true;
            this.countNotification.BackColor = System.Drawing.Color.Transparent;
            this.countNotification.Cursor = System.Windows.Forms.Cursors.Hand;
            this.countNotification.Font = new System.Drawing.Font("MS PGothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countNotification.ForeColor = System.Drawing.Color.Pink;
            this.countNotification.Location = new System.Drawing.Point(616, 13);
            this.countNotification.Name = "countNotification";
            this.countNotification.Size = new System.Drawing.Size(19, 19);
            this.countNotification.TabIndex = 75;
            this.countNotification.Text = "0";
            // 
            // notifBTN
            // 
            this.notifBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.notifBTN.BackColor = System.Drawing.Color.Transparent;
            this.notifBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.notifBTN.Image = ((System.Drawing.Image)(resources.GetObject("notifBTN.Image")));
            this.notifBTN.ImageActive = null;
            this.notifBTN.Location = new System.Drawing.Point(585, 3);
            this.notifBTN.Name = "notifBTN";
            this.notifBTN.Size = new System.Drawing.Size(28, 29);
            this.notifBTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.notifBTN.TabIndex = 74;
            this.notifBTN.TabStop = false;
            this.notifBTN.Zoom = 10;
            this.notifBTN.Click += new System.EventHandler(this.notifBTN_Click);
            // 
            // searchText
            // 
            this.searchText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchText.BackColor = System.Drawing.Color.White;
            this.searchText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.searchText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.searchText.HintForeColor = System.Drawing.Color.Gray;
            this.searchText.HintText = "Search";
            this.searchText.isPassword = false;
            this.searchText.LineFocusedColor = System.Drawing.Color.Gray;
            this.searchText.LineIdleColor = System.Drawing.Color.Gray;
            this.searchText.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.searchText.LineThickness = 3;
            this.searchText.Location = new System.Drawing.Point(129, 13);
            this.searchText.Margin = new System.Windows.Forms.Padding(4);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(417, 33);
            this.searchText.TabIndex = 73;
            this.searchText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.searchText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchText_KeyDown);
            // 
            // tray
            // 
            this.tray.Icon = ((System.Drawing.Icon)(resources.GetObject("tray.Icon")));
            this.tray.Text = "JobNotifier";
            this.tray.Visible = true;
            // 
            // gradientTop
            // 
            this.gradientTop.BackColor = System.Drawing.Color.Transparent;
            this.gradientTop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gradientTop.BackgroundImage")));
            this.gradientTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gradientTop.Controls.Add(this.notifBTN);
            this.gradientTop.Controls.Add(this.searchText);
            this.gradientTop.Controls.Add(this.countNotification);
            this.gradientTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradientTop.GradientBottomLeft = System.Drawing.Color.DeepPink;
            this.gradientTop.GradientBottomRight = System.Drawing.Color.BlueViolet;
            this.gradientTop.GradientTopLeft = System.Drawing.SystemColors.WindowText;
            this.gradientTop.GradientTopRight = System.Drawing.SystemColors.WindowText;
            this.gradientTop.Location = new System.Drawing.Point(228, 0);
            this.gradientTop.Name = "gradientTop";
            this.gradientTop.Quality = 10;
            this.gradientTop.Size = new System.Drawing.Size(670, 54);
            this.gradientTop.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(898, 543);
            this.Controls.Add(this.gradientTop);
            this.Controls.Add(this.categoryPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.jobBoardPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.sidebar.ResumeLayout(false);
            this.sidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minBTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxminBTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBTN)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.notifBTN)).EndInit();
            this.gradientTop.ResumeLayout(false);
            this.gradientTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public Bunifu.Framework.UI.BunifuDragControl dragUp;
        public Bunifu.Framework.UI.BunifuElipse homeElipse;
        public Bunifu.Framework.UI.BunifuDragControl dragSidebar;
        public System.Windows.Forms.Panel jobBoardPanel;
        public Bunifu.Framework.UI.BunifuGradientPanel sidebar;
        public Bunifu.Framework.UI.BunifuImageButton minBTN;
        public Bunifu.Framework.UI.BunifuCustomLabel userLabel;
        public Bunifu.Framework.UI.BunifuImageButton maxminBTN;
        public Bunifu.Framework.UI.BunifuImageButton closeBTN;
        public Bunifu.Framework.UI.BunifuFlatButton homebtn;
        public Bunifu.Framework.UI.BunifuFlatButton settingsBTN;
        public Bunifu.Framework.UI.BunifuFlatButton TasksBtn;
        public Bunifu.Framework.UI.BunifuFlatButton platforomsBTN;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel categoryPanel;
        public Bunifu.Framework.UI.BunifuImageButton profilebox;
        public Bunifu.Framework.UI.BunifuMaterialTextbox searchText;
        public System.Windows.Forms.NotifyIcon tray;
        public Bunifu.Framework.UI.BunifuImageButton notifBTN;
        public Bunifu.Framework.UI.BunifuCustomLabel countNotification;
        private Bunifu.Framework.UI.BunifuGradientPanel gradientTop;
    }
}

