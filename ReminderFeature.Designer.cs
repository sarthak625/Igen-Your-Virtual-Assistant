namespace IgenFinalVersion
{
    partial class ReminderFeature
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReminderFeature));
            this.RecordButton = new ns1.BunifuThinButton2();
            this.TimerLabel = new MetroFramework.Controls.MetroLabel();
            this.HourBox = new MetroFramework.Controls.MetroTextBox();
            this.MinBox = new MetroFramework.Controls.MetroTextBox();
            this.SecsBox = new MetroFramework.Controls.MetroTextBox();
            this.CountDownLabel = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.RemindButton = new ns1.BunifuThinButton2();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // RecordButton
            // 
            this.RecordButton.ActiveBorderThickness = 1;
            this.RecordButton.ActiveCornerRadius = 20;
            this.RecordButton.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.RecordButton.ActiveForecolor = System.Drawing.Color.White;
            this.RecordButton.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.RecordButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.RecordButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RecordButton.BackgroundImage")));
            this.RecordButton.ButtonText = "Record";
            this.RecordButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RecordButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecordButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.RecordButton.IdleBorderThickness = 1;
            this.RecordButton.IdleCornerRadius = 20;
            this.RecordButton.IdleFillColor = System.Drawing.Color.White;
            this.RecordButton.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.RecordButton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.RecordButton.Location = new System.Drawing.Point(76, 160);
            this.RecordButton.Margin = new System.Windows.Forms.Padding(5);
            this.RecordButton.Name = "RecordButton";
            this.RecordButton.Size = new System.Drawing.Size(203, 56);
            this.RecordButton.TabIndex = 0;
            this.RecordButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RecordButton.Click += new System.EventHandler(this.RecordButton_Click);
            // 
            // TimerLabel
            // 
            this.TimerLabel.AutoSize = true;
            this.TimerLabel.Location = new System.Drawing.Point(198, 253);
            this.TimerLabel.Name = "TimerLabel";
            this.TimerLabel.Size = new System.Drawing.Size(258, 19);
            this.TimerLabel.TabIndex = 1;
            this.TimerLabel.Text = "After how much time should i remind you?";
            // 
            // HourBox
            // 
            this.HourBox.Location = new System.Drawing.Point(198, 301);
            this.HourBox.Name = "HourBox";
            this.HourBox.Size = new System.Drawing.Size(34, 23);
            this.HourBox.TabIndex = 2;
            this.HourBox.Text = "0";
            // 
            // MinBox
            // 
            this.MinBox.Location = new System.Drawing.Point(302, 301);
            this.MinBox.Name = "MinBox";
            this.MinBox.Size = new System.Drawing.Size(34, 23);
            this.MinBox.TabIndex = 3;
            this.MinBox.Text = "0";
            // 
            // SecsBox
            // 
            this.SecsBox.Location = new System.Drawing.Point(409, 301);
            this.SecsBox.Name = "SecsBox";
            this.SecsBox.Size = new System.Drawing.Size(34, 23);
            this.SecsBox.TabIndex = 4;
            this.SecsBox.Text = "0";
            // 
            // CountDownLabel
            // 
            this.CountDownLabel.AutoSize = true;
            this.CountDownLabel.Location = new System.Drawing.Point(176, 119);
            this.CountDownLabel.Name = "CountDownLabel";
            this.CountDownLabel.Size = new System.Drawing.Size(16, 19);
            this.CountDownLabel.TabIndex = 5;
            this.CountDownLabel.Text = "0";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(238, 301);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(41, 19);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "hours";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(352, 301);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(36, 19);
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "mins";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(449, 301);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(32, 19);
            this.metroLabel3.TabIndex = 8;
            this.metroLabel3.Text = "secs";
            // 
            // RemindButton
            // 
            this.RemindButton.ActiveBorderThickness = 1;
            this.RemindButton.ActiveCornerRadius = 20;
            this.RemindButton.ActiveFillColor = System.Drawing.Color.Red;
            this.RemindButton.ActiveForecolor = System.Drawing.Color.White;
            this.RemindButton.ActiveLineColor = System.Drawing.Color.Yellow;
            this.RemindButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.RemindButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RemindButton.BackgroundImage")));
            this.RemindButton.ButtonText = "Remind";
            this.RemindButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RemindButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemindButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.RemindButton.IdleBorderThickness = 1;
            this.RemindButton.IdleCornerRadius = 20;
            this.RemindButton.IdleFillColor = System.Drawing.Color.White;
            this.RemindButton.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.RemindButton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.RemindButton.Location = new System.Drawing.Point(438, 160);
            this.RemindButton.Margin = new System.Windows.Forms.Padding(5);
            this.RemindButton.Name = "RemindButton";
            this.RemindButton.Size = new System.Drawing.Size(203, 56);
            this.RemindButton.TabIndex = 9;
            this.RemindButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RemindButton.Click += new System.EventHandler(this.RemindButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(409, 57);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(270, 95);
            this.listBox1.TabIndex = 10;
            // 
            // ReminderFeature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 407);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.RemindButton);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.CountDownLabel);
            this.Controls.Add(this.SecsBox);
            this.Controls.Add(this.MinBox);
            this.Controls.Add(this.HourBox);
            this.Controls.Add(this.TimerLabel);
            this.Controls.Add(this.RecordButton);
            this.Name = "ReminderFeature";
            this.Text = "ReminderFeature";
            this.Load += new System.EventHandler(this.ReminderFeature_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ns1.BunifuThinButton2 RecordButton;
        private MetroFramework.Controls.MetroLabel TimerLabel;
        private MetroFramework.Controls.MetroTextBox HourBox;
        private MetroFramework.Controls.MetroTextBox MinBox;
        private MetroFramework.Controls.MetroTextBox SecsBox;
        private MetroFramework.Controls.MetroLabel CountDownLabel;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private ns1.BunifuThinButton2 RemindButton;
        private System.Windows.Forms.ListBox listBox1;
    }
}