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
            this.spaceInCProgress = new ns1.BunifuCircleProgressbar();
            this.spaceInIProgress = new ns1.BunifuCircleProgressbar();
            this.spaceInFProgress = new ns1.BunifuCircleProgressbar();
            this.CLabel = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // TimeBlock
            // 
            this.TimeBlock.Location = new System.Drawing.Point(513, 60);
            this.TimeBlock.Margin = new System.Windows.Forms.Padding(5);
            this.TimeBlock.Name = "TimeBlock";
            this.TimeBlock.Size = new System.Drawing.Size(215, 77);
            this.TimeBlock.TabIndex = 0;
            this.TimeBlock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DateBlock
            // 
            this.DateBlock.BackColor = System.Drawing.Color.LightCoral;
            this.DateBlock.CustomBackground = true;
            this.DateBlock.Location = new System.Drawing.Point(513, 165);
            this.DateBlock.Margin = new System.Windows.Forms.Padding(5);
            this.DateBlock.Name = "DateBlock";
            this.DateBlock.Size = new System.Drawing.Size(215, 77);
            this.DateBlock.TabIndex = 2;
            this.DateBlock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // spaceInCProgress
            // 
            this.spaceInCProgress.animated = false;
            this.spaceInCProgress.animationIterval = 5;
            this.spaceInCProgress.animationSpeed = 300;
            this.spaceInCProgress.BackColor = System.Drawing.Color.White;
            this.spaceInCProgress.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("spaceInCProgress.BackgroundImage")));
            this.spaceInCProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.spaceInCProgress.ForeColor = System.Drawing.Color.SeaGreen;
            this.spaceInCProgress.LabelVisible = true;
            this.spaceInCProgress.LineProgressThickness = 8;
            this.spaceInCProgress.LineThickness = 5;
            this.spaceInCProgress.Location = new System.Drawing.Point(30, 83);
            this.spaceInCProgress.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.spaceInCProgress.MaxValue = 100;
            this.spaceInCProgress.Name = "spaceInCProgress";
            this.spaceInCProgress.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.spaceInCProgress.ProgressColor = System.Drawing.Color.SeaGreen;
            this.spaceInCProgress.Size = new System.Drawing.Size(132, 132);
            this.spaceInCProgress.TabIndex = 3;
            this.spaceInCProgress.Value = 0;
            // 
            // spaceInIProgress
            // 
            this.spaceInIProgress.animated = false;
            this.spaceInIProgress.animationIterval = 5;
            this.spaceInIProgress.animationSpeed = 300;
            this.spaceInIProgress.BackColor = System.Drawing.Color.White;
            this.spaceInIProgress.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("spaceInIProgress.BackgroundImage")));
            this.spaceInIProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.spaceInIProgress.ForeColor = System.Drawing.Color.SeaGreen;
            this.spaceInIProgress.LabelVisible = true;
            this.spaceInIProgress.LineProgressThickness = 8;
            this.spaceInIProgress.LineThickness = 5;
            this.spaceInIProgress.Location = new System.Drawing.Point(207, 83);
            this.spaceInIProgress.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.spaceInIProgress.MaxValue = 100;
            this.spaceInIProgress.Name = "spaceInIProgress";
            this.spaceInIProgress.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.spaceInIProgress.ProgressColor = System.Drawing.Color.SeaGreen;
            this.spaceInIProgress.Size = new System.Drawing.Size(132, 132);
            this.spaceInIProgress.TabIndex = 4;
            this.spaceInIProgress.Value = 0;
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
            this.spaceInFProgress.LineThickness = 5;
            this.spaceInFProgress.Location = new System.Drawing.Point(30, 280);
            this.spaceInFProgress.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.spaceInFProgress.MaxValue = 100;
            this.spaceInFProgress.Name = "spaceInFProgress";
            this.spaceInFProgress.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.spaceInFProgress.ProgressColor = System.Drawing.Color.SeaGreen;
            this.spaceInFProgress.Size = new System.Drawing.Size(132, 132);
            this.spaceInFProgress.TabIndex = 5;
            this.spaceInFProgress.Value = 0;
            // 
            // CLabel
            // 
            this.CLabel.AutoSize = true;
            this.CLabel.Location = new System.Drawing.Point(53, 223);
            this.CLabel.Name = "CLabel";
            this.CLabel.Size = new System.Drawing.Size(96, 19);
            this.CLabel.TabIndex = 6;
            this.CLabel.Text = "used in C drive";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(232, 223);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(91, 19);
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "used in I Drive";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(53, 434);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(94, 19);
            this.metroLabel3.TabIndex = 8;
            this.metroLabel3.Text = "used in F drive";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Info;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(355, 280);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(398, 173);
            this.listBox1.TabIndex = 9;
            // 
            // Igen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 537);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.CLabel);
            this.Controls.Add(this.spaceInFProgress);
            this.Controls.Add(this.spaceInIProgress);
            this.Controls.Add(this.spaceInCProgress);
            this.Controls.Add(this.DateBlock);
            this.Controls.Add(this.TimeBlock);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Igen";
            this.Style = MetroFramework.MetroColorStyle.Blue;
            this.Text = "Igen";
            this.Load += new System.EventHandler(this.Igen_Load);
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
        private System.Windows.Forms.ListBox listBox1;
    }
}

