namespace IgenFinalVersion
{
    partial class ReminderToAdd
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
            this.ToRemindTextbox = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ToRemindTextbox
            // 
            this.ToRemindTextbox.BorderColor = System.Drawing.Color.SeaGreen;
            this.ToRemindTextbox.Location = new System.Drawing.Point(23, 63);
            this.ToRemindTextbox.Multiline = true;
            this.ToRemindTextbox.Name = "ToRemindTextbox";
            this.ToRemindTextbox.Size = new System.Drawing.Size(222, 106);
            this.ToRemindTextbox.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ReminderToAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ToRemindTextbox);
            this.Name = "ReminderToAdd";
            this.Text = "Reminder To Add";
            this.Load += new System.EventHandler(this.ReminderToAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WindowsFormsControlLibrary1.BunifuCustomTextbox ToRemindTextbox;
        private System.Windows.Forms.Button button1;
    }
}