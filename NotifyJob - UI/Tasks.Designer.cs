namespace NotifyJob___UI
{
    partial class Tasks
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tasks));
            this.elipseTask = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.RingOptionlabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.RingNo = new System.Windows.Forms.CheckBox();
            this.RingYes = new System.Windows.Forms.CheckBox();
            this.taskTimer = new System.Windows.Forms.ComboBox();
            this.KeyWordstxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.dragTask = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.dragtaskheader = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.addtaskBTN = new Bunifu.Framework.UI.BunifuFlatButton();
            this.keywordLbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.timeSelectlbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SuspendLayout();
            // 
            // elipseTask
            // 
            this.elipseTask.ElipseRadius = 5;
            this.elipseTask.TargetControl = this;
            // 
            // RingOptionlabel
            // 
            this.RingOptionlabel.AutoSize = true;
            this.RingOptionlabel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RingOptionlabel.ForeColor = System.Drawing.Color.DimGray;
            this.RingOptionlabel.Location = new System.Drawing.Point(146, 112);
            this.RingOptionlabel.Name = "RingOptionlabel";
            this.RingOptionlabel.Size = new System.Drawing.Size(131, 21);
            this.RingOptionlabel.TabIndex = 75;
            this.RingOptionlabel.Text = "Ring notification?";
            // 
            // RingNo
            // 
            this.RingNo.AutoSize = true;
            this.RingNo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.RingNo.FlatAppearance.BorderSize = 0;
            this.RingNo.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(52)))), ((int)(((byte)(74)))));
            this.RingNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RingNo.Font = new System.Drawing.Font("MS PGothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RingNo.ForeColor = System.Drawing.Color.DimGray;
            this.RingNo.Location = new System.Drawing.Point(345, 118);
            this.RingNo.Name = "RingNo";
            this.RingNo.Size = new System.Drawing.Size(35, 16);
            this.RingNo.TabIndex = 74;
            this.RingNo.Text = "No";
            this.RingNo.UseVisualStyleBackColor = true;
            // 
            // RingYes
            // 
            this.RingYes.AutoSize = true;
            this.RingYes.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.RingYes.FlatAppearance.BorderSize = 0;
            this.RingYes.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(52)))), ((int)(((byte)(74)))));
            this.RingYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RingYes.Font = new System.Drawing.Font("MS PGothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RingYes.ForeColor = System.Drawing.Color.DimGray;
            this.RingYes.Location = new System.Drawing.Point(288, 118);
            this.RingYes.Name = "RingYes";
            this.RingYes.Size = new System.Drawing.Size(40, 16);
            this.RingYes.TabIndex = 73;
            this.RingYes.Text = "Yes";
            this.RingYes.UseVisualStyleBackColor = true;
            // 
            // taskTimer
            // 
            this.taskTimer.FormattingEnabled = true;
            this.taskTimer.Location = new System.Drawing.Point(160, 78);
            this.taskTimer.Name = "taskTimer";
            this.taskTimer.Size = new System.Drawing.Size(285, 21);
            this.taskTimer.TabIndex = 71;
            // 
            // KeyWordstxt
            // 
            this.KeyWordstxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.KeyWordstxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.KeyWordstxt.ForeColor = System.Drawing.Color.DimGray;
            this.KeyWordstxt.HintForeColor = System.Drawing.Color.DimGray;
            this.KeyWordstxt.HintText = "C#, Joomla";
            this.KeyWordstxt.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.KeyWordstxt.isPassword = false;
            this.KeyWordstxt.LineFocusedColor = System.Drawing.Color.DimGray;
            this.KeyWordstxt.LineIdleColor = System.Drawing.Color.Gray;
            this.KeyWordstxt.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.KeyWordstxt.LineThickness = 3;
            this.KeyWordstxt.Location = new System.Drawing.Point(160, 38);
            this.KeyWordstxt.Margin = new System.Windows.Forms.Padding(4);
            this.KeyWordstxt.Name = "KeyWordstxt";
            this.KeyWordstxt.Size = new System.Drawing.Size(285, 33);
            this.KeyWordstxt.TabIndex = 70;
            this.KeyWordstxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // dragTask
            // 
            this.dragTask.Fixed = true;
            this.dragTask.Horizontal = true;
            this.dragTask.TargetControl = null;
            this.dragTask.Vertical = true;
            // 
            // dragtaskheader
            // 
            this.dragtaskheader.Fixed = true;
            this.dragtaskheader.Horizontal = true;
            this.dragtaskheader.TargetControl = null;
            this.dragtaskheader.Vertical = true;
            // 
            // addtaskBTN
            // 
            this.addtaskBTN.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.addtaskBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addtaskBTN.BackColor = System.Drawing.Color.Orange;
            this.addtaskBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addtaskBTN.BorderRadius = 0;
            this.addtaskBTN.ButtonText = "Add Task";
            this.addtaskBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addtaskBTN.DisabledColor = System.Drawing.Color.Gray;
            this.addtaskBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(84)))), ((int)(((byte)(95)))));
            this.addtaskBTN.Iconcolor = System.Drawing.Color.Transparent;
            this.addtaskBTN.Iconimage = ((System.Drawing.Image)(resources.GetObject("addtaskBTN.Iconimage")));
            this.addtaskBTN.Iconimage_right = null;
            this.addtaskBTN.Iconimage_right_Selected = null;
            this.addtaskBTN.Iconimage_Selected = null;
            this.addtaskBTN.IconMarginLeft = 0;
            this.addtaskBTN.IconMarginRight = 0;
            this.addtaskBTN.IconRightVisible = true;
            this.addtaskBTN.IconRightZoom = 0D;
            this.addtaskBTN.IconVisible = false;
            this.addtaskBTN.IconZoom = 90D;
            this.addtaskBTN.IsTab = false;
            this.addtaskBTN.Location = new System.Drawing.Point(351, 148);
            this.addtaskBTN.Name = "addtaskBTN";
            this.addtaskBTN.Normalcolor = System.Drawing.Color.Orange;
            this.addtaskBTN.OnHovercolor = System.Drawing.Color.Orange;
            this.addtaskBTN.OnHoverTextColor = System.Drawing.Color.Orange;
            this.addtaskBTN.selected = false;
            this.addtaskBTN.Size = new System.Drawing.Size(131, 26);
            this.addtaskBTN.TabIndex = 72;
            this.addtaskBTN.Text = "Add Task";
            this.addtaskBTN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addtaskBTN.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.addtaskBTN.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // keywordLbl
            // 
            this.keywordLbl.AutoSize = true;
            this.keywordLbl.BackColor = System.Drawing.Color.White;
            this.keywordLbl.Font = new System.Drawing.Font("MS PGothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keywordLbl.ForeColor = System.Drawing.Color.Gray;
            this.keywordLbl.Location = new System.Drawing.Point(41, 54);
            this.keywordLbl.Name = "keywordLbl";
            this.keywordLbl.Size = new System.Drawing.Size(86, 19);
            this.keywordLbl.TabIndex = 76;
            this.keywordLbl.Text = "Keywords";
            // 
            // timeSelectlbl
            // 
            this.timeSelectlbl.AutoSize = true;
            this.timeSelectlbl.BackColor = System.Drawing.Color.White;
            this.timeSelectlbl.Font = new System.Drawing.Font("MS PGothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeSelectlbl.ForeColor = System.Drawing.Color.Gray;
            this.timeSelectlbl.Location = new System.Drawing.Point(41, 80);
            this.timeSelectlbl.Name = "timeSelectlbl";
            this.timeSelectlbl.Size = new System.Drawing.Size(110, 19);
            this.timeSelectlbl.TabIndex = 77;
            this.timeSelectlbl.Text = "Every x(min)";
            // 
            // Tasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.timeSelectlbl);
            this.Controls.Add(this.keywordLbl);
            this.Controls.Add(this.RingOptionlabel);
            this.Controls.Add(this.RingNo);
            this.Controls.Add(this.RingYes);
            this.Controls.Add(this.taskTimer);
            this.Controls.Add(this.KeyWordstxt);
            this.Controls.Add(this.addtaskBTN);
            this.Name = "Tasks";
            this.Size = new System.Drawing.Size(482, 177);
            this.Load += new System.EventHandler(this.Tasks_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse elipseTask;
        private Bunifu.Framework.UI.BunifuCustomLabel RingOptionlabel;
        private System.Windows.Forms.CheckBox RingNo;
        private System.Windows.Forms.CheckBox RingYes;
        private System.Windows.Forms.ComboBox taskTimer;
        private Bunifu.Framework.UI.BunifuMaterialTextbox KeyWordstxt;
        private Bunifu.Framework.UI.BunifuFlatButton addtaskBTN;
        private Bunifu.Framework.UI.BunifuDragControl dragTask;
        private Bunifu.Framework.UI.BunifuDragControl dragtaskheader;
        public Bunifu.Framework.UI.BunifuCustomLabel timeSelectlbl;
        public Bunifu.Framework.UI.BunifuCustomLabel keywordLbl;
    }
}
