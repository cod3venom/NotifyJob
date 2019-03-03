namespace NotifyJob___UI.Confs
{
    partial class _browser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_browser));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.dismissPanel = new System.Windows.Forms.Panel();
            this.headerLBL = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.minBTN = new Bunifu.Framework.UI.BunifuImageButton();
            this.maxminBTN = new Bunifu.Framework.UI.BunifuImageButton();
            this.closeBTN = new Bunifu.Framework.UI.BunifuImageButton();
            this.browserControlsPanel = new System.Windows.Forms.Panel();
            this.findIco = new Bunifu.Framework.UI.BunifuImageButton();
            this.searchText = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.ForwardArrow = new Bunifu.Framework.UI.BunifuImageButton();
            this.backArrow = new Bunifu.Framework.UI.BunifuImageButton();
            this.browserpanel = new System.Windows.Forms.Panel();
            this.web = new System.Windows.Forms.WebBrowser();
            this.topdrag = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.searchbardrag = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dismissPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minBTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxminBTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBTN)).BeginInit();
            this.browserControlsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.findIco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ForwardArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backArrow)).BeginInit();
            this.browserpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // dismissPanel
            // 
            this.dismissPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(237)))));
            this.dismissPanel.Controls.Add(this.headerLBL);
            this.dismissPanel.Controls.Add(this.minBTN);
            this.dismissPanel.Controls.Add(this.maxminBTN);
            this.dismissPanel.Controls.Add(this.closeBTN);
            this.dismissPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.dismissPanel.Location = new System.Drawing.Point(0, 0);
            this.dismissPanel.Name = "dismissPanel";
            this.dismissPanel.Size = new System.Drawing.Size(800, 25);
            this.dismissPanel.TabIndex = 0;
            // 
            // headerLBL
            // 
            this.headerLBL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.headerLBL.AutoEllipsis = true;
            this.headerLBL.AutoSize = true;
            this.headerLBL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(237)))));
            this.headerLBL.Font = new System.Drawing.Font("MS PGothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLBL.ForeColor = System.Drawing.Color.Gray;
            this.headerLBL.Location = new System.Drawing.Point(302, 5);
            this.headerLBL.Name = "headerLBL";
            this.headerLBL.Size = new System.Drawing.Size(64, 19);
            this.headerLBL.TabIndex = 19;
            this.headerLBL.Text = "header";
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
            this.minBTN.TabIndex = 18;
            this.minBTN.TabStop = false;
            this.minBTN.Zoom = 10;
            this.minBTN.Click += new System.EventHandler(this.minBTN_Click);
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
            this.maxminBTN.TabIndex = 17;
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
            this.closeBTN.TabIndex = 16;
            this.closeBTN.TabStop = false;
            this.closeBTN.Zoom = 10;
            this.closeBTN.Click += new System.EventHandler(this.closeBTN_Click);
            // 
            // browserControlsPanel
            // 
            this.browserControlsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(237)))));
            this.browserControlsPanel.Controls.Add(this.findIco);
            this.browserControlsPanel.Controls.Add(this.searchText);
            this.browserControlsPanel.Controls.Add(this.ForwardArrow);
            this.browserControlsPanel.Controls.Add(this.backArrow);
            this.browserControlsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.browserControlsPanel.Location = new System.Drawing.Point(0, 25);
            this.browserControlsPanel.Name = "browserControlsPanel";
            this.browserControlsPanel.Size = new System.Drawing.Size(800, 36);
            this.browserControlsPanel.TabIndex = 2;
            // 
            // findIco
            // 
            this.findIco.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.findIco.BackColor = System.Drawing.Color.Transparent;
            this.findIco.Enabled = false;
            this.findIco.Image = global::NotifyJob___UI.Properties.Resources.find;
            this.findIco.ImageActive = null;
            this.findIco.Location = new System.Drawing.Point(725, 6);
            this.findIco.Name = "findIco";
            this.findIco.Size = new System.Drawing.Size(20, 20);
            this.findIco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.findIco.TabIndex = 75;
            this.findIco.TabStop = false;
            this.findIco.Zoom = 10;
            // 
            // searchText
            // 
            this.searchText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(237)))));
            this.searchText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchText.Enabled = false;
            this.searchText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.searchText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.searchText.HintForeColor = System.Drawing.Color.Gray;
            this.searchText.HintText = "Search";
            this.searchText.isPassword = false;
            this.searchText.LineFocusedColor = System.Drawing.Color.Gray;
            this.searchText.LineIdleColor = System.Drawing.Color.Gray;
            this.searchText.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.searchText.LineThickness = 3;
            this.searchText.Location = new System.Drawing.Point(93, 1);
            this.searchText.Margin = new System.Windows.Forms.Padding(4);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(673, 29);
            this.searchText.TabIndex = 74;
            this.searchText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ForwardArrow
            // 
            this.ForwardArrow.BackColor = System.Drawing.Color.Transparent;
            this.ForwardArrow.Image = global::NotifyJob___UI.Properties.Resources.right;
            this.ForwardArrow.ImageActive = null;
            this.ForwardArrow.Location = new System.Drawing.Point(35, 7);
            this.ForwardArrow.Name = "ForwardArrow";
            this.ForwardArrow.Size = new System.Drawing.Size(23, 23);
            this.ForwardArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ForwardArrow.TabIndex = 18;
            this.ForwardArrow.TabStop = false;
            this.ForwardArrow.Zoom = 10;
            this.ForwardArrow.Click += new System.EventHandler(this.ForwardArrow_Click);
            // 
            // backArrow
            // 
            this.backArrow.BackColor = System.Drawing.Color.Transparent;
            this.backArrow.Image = global::NotifyJob___UI.Properties.Resources.left;
            this.backArrow.ImageActive = null;
            this.backArrow.Location = new System.Drawing.Point(7, 7);
            this.backArrow.Name = "backArrow";
            this.backArrow.Size = new System.Drawing.Size(23, 23);
            this.backArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backArrow.TabIndex = 17;
            this.backArrow.TabStop = false;
            this.backArrow.Zoom = 10;
            this.backArrow.Click += new System.EventHandler(this.backArrow_Click);
            // 
            // browserpanel
            // 
            this.browserpanel.Controls.Add(this.web);
            this.browserpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.browserpanel.Location = new System.Drawing.Point(0, 61);
            this.browserpanel.Name = "browserpanel";
            this.browserpanel.Size = new System.Drawing.Size(800, 389);
            this.browserpanel.TabIndex = 3;
            // 
            // web
            // 
            this.web.Dock = System.Windows.Forms.DockStyle.Fill;
            this.web.Location = new System.Drawing.Point(0, 0);
            this.web.MinimumSize = new System.Drawing.Size(20, 20);
            this.web.Name = "web";
            this.web.ScriptErrorsSuppressed = true;
            this.web.Size = new System.Drawing.Size(800, 389);
            this.web.TabIndex = 0;
            this.web.WebBrowserShortcutsEnabled = false;
            this.web.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.web_DocumentCompleted);
            // 
            // topdrag
            // 
            this.topdrag.Fixed = true;
            this.topdrag.Horizontal = true;
            this.topdrag.TargetControl = this.dismissPanel;
            this.topdrag.Vertical = true;
            // 
            // searchbardrag
            // 
            this.searchbardrag.Fixed = true;
            this.searchbardrag.Horizontal = true;
            this.searchbardrag.TargetControl = this.browserControlsPanel;
            this.searchbardrag.Vertical = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 389);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(5, 445);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(795, 5);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(795, 61);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 384);
            this.panel3.TabIndex = 6;
            // 
            // _browser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.browserpanel);
            this.Controls.Add(this.browserControlsPanel);
            this.Controls.Add(this.dismissPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "_browser";
            this.Text = "_browser";
            this.Load += new System.EventHandler(this._browser_Load);
            this.dismissPanel.ResumeLayout(false);
            this.dismissPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minBTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxminBTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBTN)).EndInit();
            this.browserControlsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.findIco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ForwardArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backArrow)).EndInit();
            this.browserpanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        public System.Windows.Forms.Panel dismissPanel;
        public Bunifu.Framework.UI.BunifuImageButton minBTN;
        public Bunifu.Framework.UI.BunifuImageButton maxminBTN;
        public Bunifu.Framework.UI.BunifuImageButton closeBTN;
        public System.Windows.Forms.Panel browserControlsPanel;
        public Bunifu.Framework.UI.BunifuImageButton backArrow;
        public Bunifu.Framework.UI.BunifuImageButton ForwardArrow;
        public Bunifu.Framework.UI.BunifuImageButton findIco;
        public Bunifu.Framework.UI.BunifuMaterialTextbox searchText;
        public System.Windows.Forms.Panel browserpanel;
        private Bunifu.Framework.UI.BunifuDragControl topdrag;
        private Bunifu.Framework.UI.BunifuDragControl searchbardrag;
        private System.Windows.Forms.WebBrowser web;
        public Bunifu.Framework.UI.BunifuCustomLabel headerLBL;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}