namespace IgenFinalVersion
{
    partial class Igen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Igen));
            this.TimeBlock = new MetroFramework.Controls.MetroTile();
            this.DateBlock = new MetroFramework.Controls.MetroTile();
            this.CLabel = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.ConvoBox = new System.Windows.Forms.ListBox();
            this.StartButton = new MetroFramework.Controls.MetroButton();
            this.ListenerLabel = new MetroFramework.Controls.MetroLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RFButton = new ns1.BunifuFlatButton();
            this.GEButton = new ns1.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.spaceInFProgress = new ns1.BunifuCircleProgressbar();
            this.spaceInIProgress = new ns1.BunifuCircleProgressbar();
            this.spaceInCProgress = new ns1.BunifuCircleProgressbar();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TimeBlock
            // 
            this.TimeBlock.Location = new System.Drawing.Point(936, 69);
            this.TimeBlock.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TimeBlock.Name = "TimeBlock";
            this.TimeBlock.Size = new System.Drawing.Size(251, 89);
            this.TimeBlock.TabIndex = 0;
            this.TimeBlock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DateBlock
            // 
            this.DateBlock.BackColor = System.Drawing.Color.LightCoral;
            this.DateBlock.CustomBackground = true;
            this.DateBlock.Location = new System.Drawing.Point(936, 207);
            this.DateBlock.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.DateBlock.Name = "DateBlock";
            this.DateBlock.Size = new System.Drawing.Size(251, 89);
            this.DateBlock.TabIndex = 2;
            this.DateBlock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CLabel
            // 
            this.CLabel.AutoSize = true;
            this.CLabel.Location = new System.Drawing.Point(387, 258);
            this.CLabel.Name = "CLabel";
            this.CLabel.Size = new System.Drawing.Size(96, 19);
            this.CLabel.TabIndex = 6;
            this.CLabel.Text = "used in C drive";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(614, 258);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(91, 19);
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "used in I Drive";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(387, 501);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(94, 19);
            this.metroLabel3.TabIndex = 8;
            this.metroLabel3.Text = "used in F drive";
            // 
            // ConvoBox
            // 
            this.ConvoBox.BackColor = System.Drawing.SystemColors.Info;
            this.ConvoBox.FormattingEnabled = true;
            this.ConvoBox.ItemHeight = 15;
            this.ConvoBox.Location = new System.Drawing.Point(752, 338);
            this.ConvoBox.Name = "ConvoBox";
            this.ConvoBox.Size = new System.Drawing.Size(464, 199);
            this.ConvoBox.TabIndex = 9;
            // 
            // StartButton
            // 
            this.StartButton.Highlight = true;
            this.StartButton.Location = new System.Drawing.Point(587, 366);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(117, 74);
            this.StartButton.TabIndex = 11;
            this.StartButton.Text = "Start";
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // ListenerLabel
            // 
            this.ListenerLabel.AutoSize = true;
            this.ListenerLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.ListenerLabel.ForeColor = System.Drawing.Color.LimeGreen;
            this.ListenerLabel.Location = new System.Drawing.Point(752, 313);
            this.ListenerLabel.Name = "ListenerLabel";
            this.ListenerLabel.Size = new System.Drawing.Size(73, 19);
            this.ListenerLabel.TabIndex = 12;
            this.ListenerLabel.Text = "Listening...";
            this.ListenerLabel.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateBlue;
            this.panel1.Controls.Add(this.RFButton);
            this.panel1.Controls.Add(this.GEButton);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(23, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 518);
            this.panel1.TabIndex = 13;
            // 
            // RFButton
            // 
            this.RFButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.RFButton.BackColor = System.Drawing.Color.YellowGreen;
            this.RFButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RFButton.BorderRadius = 0;
            this.RFButton.ButtonText = "Reminder Feature";
            this.RFButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RFButton.DisabledColor = System.Drawing.Color.Gray;
            this.RFButton.Iconcolor = System.Drawing.Color.Transparent;
            this.RFButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("RFButton.Iconimage")));
            this.RFButton.Iconimage_right = null;
            this.RFButton.Iconimage_right_Selected = null;
            this.RFButton.Iconimage_Selected = null;
            this.RFButton.IconMarginLeft = 0;
            this.RFButton.IconMarginRight = 0;
            this.RFButton.IconRightVisible = true;
            this.RFButton.IconRightZoom = 0D;
            this.RFButton.IconVisible = true;
            this.RFButton.IconZoom = 90D;
            this.RFButton.IsTab = false;
            this.RFButton.Location = new System.Drawing.Point(23, 297);
            this.RFButton.Name = "RFButton";
            this.RFButton.Normalcolor = System.Drawing.Color.YellowGreen;
            this.RFButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.RFButton.OnHoverTextColor = System.Drawing.Color.White;
            this.RFButton.selected = false;
            this.RFButton.Size = new System.Drawing.Size(251, 53);
            this.RFButton.TabIndex = 2;
            this.RFButton.Text = "Reminder Feature";
            this.RFButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RFButton.Textcolor = System.Drawing.Color.White;
            this.RFButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RFButton.Click += new System.EventHandler(this.RFButton_Click);
            // 
            // GEButton
            // 
            this.GEButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.GEButton.BackColor = System.Drawing.Color.YellowGreen;
            this.GEButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GEButton.BorderRadius = 0;
            this.GEButton.ButtonText = "Google Engine";
            this.GEButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GEButton.DisabledColor = System.Drawing.Color.Gray;
            this.GEButton.Iconcolor = System.Drawing.Color.Transparent;
            this.GEButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("GEButton.Iconimage")));
            this.GEButton.Iconimage_right = null;
            this.GEButton.Iconimage_right_Selected = null;
            this.GEButton.Iconimage_Selected = null;
            this.GEButton.IconMarginLeft = 0;
            this.GEButton.IconMarginRight = 0;
            this.GEButton.IconRightVisible = true;
            this.GEButton.IconRightZoom = 0D;
            this.GEButton.IconVisible = true;
            this.GEButton.IconZoom = 90D;
            this.GEButton.IsTab = false;
            this.GEButton.Location = new System.Drawing.Point(23, 218);
            this.GEButton.Name = "GEButton";
            this.GEButton.Normalcolor = System.Drawing.Color.YellowGreen;
            this.GEButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.GEButton.OnHoverTextColor = System.Drawing.Color.White;
            this.GEButton.selected = false;
            this.GEButton.Size = new System.Drawing.Size(251, 53);
            this.GEButton.TabIndex = 1;
            this.GEButton.Text = "Google Engine";
            this.GEButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GEButton.Textcolor = System.Drawing.Color.White;
            this.GEButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GEButton.Click += new System.EventHandler(this.GEButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::IgenFinalVersion.Properties.Resources.IGEN2;
            this.pictureBox1.Location = new System.Drawing.Point(23, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 137);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // spaceInFProgress
            // 
            this.spaceInFProgress.animated = false;
            this.spaceInFProgress.animationIterval = 5;
            this.spaceInFProgress.animationSpeed = 300;
            this.spaceInFProgress.BackColor = System.Drawing.Color.White;
            this.spaceInFProgress.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("spaceInFProgress.BackgroundImage")));
            this.spaceInFProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.spaceInFProgress.ForeColor = System.Drawing.Color.SeaGreen;
            this.spaceInFProgress.LabelVisible = true;
            this.spaceInFProgress.LineProgressThickness = 8;
            this.spaceInFProgress.LineThickness = 2;
            this.spaceInFProgress.Location = new System.Drawing.Point(357, 338);
            this.spaceInFProgress.Margin = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.spaceInFProgress.MaxValue = 100;
            this.spaceInFProgress.Name = "spaceInFProgress";
            this.spaceInFProgress.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.spaceInFProgress.ProgressColor = System.Drawing.Color.SeaGreen;
            this.spaceInFProgress.Size = new System.Drawing.Size(152, 152);
            this.spaceInFProgress.TabIndex = 5;
            this.spaceInFProgress.Value = 0;
            // 
            // spaceInIProgress
            // 
            this.spaceInIProgress.animated = false;
            this.spaceInIProgress.animationIterval = 5;
            this.spaceInIProgress.animationSpeed = 300;
            this.spaceInIProgress.BackColor = System.Drawing.Color.White;
            this.spaceInIProgress.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("spaceInIProgress.BackgroundImage")));
            this.spaceInIProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.spaceInIProgress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(155)))), ((int)(((byte)(45)))));
            this.spaceInIProgress.LabelVisible = true;
            this.spaceInIProgress.LineProgressThickness = 8;
            this.spaceInIProgress.LineThickness = 2;
            this.spaceInIProgress.Location = new System.Drawing.Point(587, 80);
            this.spaceInIProgress.Margin = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.spaceInIProgress.MaxValue = 100;
            this.spaceInIProgress.Name = "spaceInIProgress";
            this.spaceInIProgress.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.spaceInIProgress.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(155)))), ((int)(((byte)(45)))));
            this.spaceInIProgress.Size = new System.Drawing.Size(152, 152);
            this.spaceInIProgress.TabIndex = 4;
            this.spaceInIProgress.Value = 0;
            // 
            // spaceInCProgress
            // 
            this.spaceInCProgress.animated = false;
            this.spaceInCProgress.animationIterval = 5;
            this.spaceInCProgress.animationSpeed = 300;
            this.spaceInCProgress.BackColor = System.Drawing.Color.White;
            this.spaceInCProgress.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("spaceInCProgress.BackgroundImage")));
            this.spaceInCProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.spaceInCProgress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(48)))), ((int)(((byte)(93)))));
            this.spaceInCProgress.LabelVisible = true;
            this.spaceInCProgress.LineProgressThickness = 8;
            this.spaceInCProgress.LineThickness = 2;
            this.spaceInCProgress.Location = new System.Drawing.Point(357, 80);
            this.spaceInCProgress.Margin = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.spaceInCProgress.MaxValue = 100;
            this.spaceInCProgress.Name = "spaceInCProgress";
            this.spaceInCProgress.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.spaceInCProgress.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(48)))), ((int)(((byte)(93)))));
            this.spaceInCProgress.Size = new System.Drawing.Size(152, 152);
            this.spaceInCProgress.TabIndex = 3;
            this.spaceInCProgress.Value = 0;
            // 
            // Igen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(1244, 610);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ListenerLabel);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.ConvoBox);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.CLabel);
            this.Controls.Add(this.spaceInFProgress);
            this.Controls.Add(this.spaceInIProgress);
            this.Controls.Add(this.spaceInCProgress);
            this.Controls.Add(this.DateBlock);
            this.Controls.Add(this.TimeBlock);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Igen";
            this.Padding = new System.Windows.Forms.Padding(23, 69, 23, 23);
            this.Style = MetroFramework.MetroColorStyle.Blue;
            this.Text = "IGEN ";
            this.Load += new System.EventHandler(this.Igen_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile TimeBlock;
        private MetroFramework.Controls.MetroTile DateBlock;
        private ns1.BunifuCircleProgressbar spaceInCProgress;
        private ns1.BunifuCircleProgressbar spaceInIProgress;
        private ns1.BunifuCircleProgressbar spaceInFProgress;
        private MetroFramework.Controls.MetroLabel CLabel;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.ListBox ConvoBox;
        private MetroFramework.Controls.MetroButton StartButton;
        private MetroFramework.Controls.MetroLabel ListenerLabel;
        private System.Windows.Forms.Panel panel1;
        private ns1.BunifuFlatButton GEButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ns1.BunifuFlatButton RFButton;
    }
}

