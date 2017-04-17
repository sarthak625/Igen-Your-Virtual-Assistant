namespace IgenFinalVersion
{
    partial class AfterHowMuchTime
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
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.HourTextBox = new MetroFramework.Controls.MetroTextBox();
            this.MinsTextBox = new MetroFramework.Controls.MetroTextBox();
            this.SecsTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(168, 125);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 27);
            this.metroButton1.TabIndex = 3;
            this.metroButton1.Text = "Ok";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // HourTextBox
            // 
            this.HourTextBox.Location = new System.Drawing.Point(23, 75);
            this.HourTextBox.Name = "HourTextBox";
            this.HourTextBox.Size = new System.Drawing.Size(39, 23);
            this.HourTextBox.TabIndex = 4;
            this.HourTextBox.Text = "0";
            this.HourTextBox.TextChanged += new System.EventHandler(this.HourTextBox_TextChanged);
            // 
            // MinsTextBox
            // 
            this.MinsTextBox.Location = new System.Drawing.Point(116, 75);
            this.MinsTextBox.Name = "MinsTextBox";
            this.MinsTextBox.Size = new System.Drawing.Size(36, 23);
            this.MinsTextBox.TabIndex = 5;
            this.MinsTextBox.Text = "0";
            this.MinsTextBox.TextChanged += new System.EventHandler(this.MinsTextBox_TextChanged);
            // 
            // SecsTextBox
            // 
            this.SecsTextBox.Location = new System.Drawing.Point(208, 75);
            this.SecsTextBox.Name = "SecsTextBox";
            this.SecsTextBox.Size = new System.Drawing.Size(35, 23);
            this.SecsTextBox.TabIndex = 6;
            this.SecsTextBox.Text = "0";
            this.SecsTextBox.TextChanged += new System.EventHandler(this.SecsTextBox_TextChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(69, 75);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(41, 19);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "hours";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(158, 75);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(36, 19);
            this.metroLabel2.TabIndex = 8;
            this.metroLabel2.Text = "mins";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(249, 75);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(32, 19);
            this.metroLabel3.TabIndex = 9;
            this.metroLabel3.Text = "secs";
            // 
            // AfterHowMuchTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 175);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.SecsTextBox);
            this.Controls.Add(this.MinsTextBox);
            this.Controls.Add(this.HourTextBox);
            this.Controls.Add(this.metroButton1);
            this.Name = "AfterHowMuchTime";
            this.Text = "After How Much Time?";
            this.Load += new System.EventHandler(this.AfterHowMuchTime_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTextBox HourTextBox;
        private MetroFramework.Controls.MetroTextBox MinsTextBox;
        private MetroFramework.Controls.MetroTextBox SecsTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
    }
}