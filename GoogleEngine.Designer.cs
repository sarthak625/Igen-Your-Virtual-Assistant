namespace IgenFinalVersion
{
    partial class GoogleEngine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GoogleEngine));
            this.RecordButton = new ns1.BunifuThinButton2();
            this.SearchButton = new ns1.BunifuThinButton2();
            this.CountDownLabel = new MetroFramework.Controls.MetroLabel();
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
            this.RecordButton.Location = new System.Drawing.Point(44, 231);
            this.RecordButton.Margin = new System.Windows.Forms.Padding(5);
            this.RecordButton.Name = "RecordButton";
            this.RecordButton.Size = new System.Drawing.Size(181, 41);
            this.RecordButton.TabIndex = 0;
            this.RecordButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RecordButton.Click += new System.EventHandler(this.RecordButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.ActiveBorderThickness = 1;
            this.SearchButton.ActiveCornerRadius = 20;
            this.SearchButton.ActiveFillColor = System.Drawing.Color.DarkOrange;
            this.SearchButton.ActiveForecolor = System.Drawing.Color.White;
            this.SearchButton.ActiveLineColor = System.Drawing.Color.Red;
            this.SearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SearchButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SearchButton.BackgroundImage")));
            this.SearchButton.ButtonText = "Search";
            this.SearchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.SearchButton.IdleBorderThickness = 1;
            this.SearchButton.IdleCornerRadius = 20;
            this.SearchButton.IdleFillColor = System.Drawing.Color.White;
            this.SearchButton.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.SearchButton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.SearchButton.Location = new System.Drawing.Point(235, 231);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(5);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(181, 41);
            this.SearchButton.TabIndex = 1;
            this.SearchButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CountDownLabel
            // 
            this.CountDownLabel.AutoSize = true;
            this.CountDownLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.CountDownLabel.Location = new System.Drawing.Point(222, 142);
            this.CountDownLabel.Name = "CountDownLabel";
            this.CountDownLabel.Size = new System.Drawing.Size(18, 25);
            this.CountDownLabel.TabIndex = 2;
            this.CountDownLabel.Text = "1";
            // 
            // GoogleEngine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(474, 386);
            this.Controls.Add(this.CountDownLabel);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.RecordButton);
            this.Name = "GoogleEngine";
            this.Text = "Google Engine";
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Load += new System.EventHandler(this.GoogleEngine_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ns1.BunifuThinButton2 RecordButton;
        private ns1.BunifuThinButton2 SearchButton;
        private MetroFramework.Controls.MetroLabel CountDownLabel;
    }
}