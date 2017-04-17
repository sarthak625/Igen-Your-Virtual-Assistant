using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IgenFinalVersion
{


    public partial class AfterHowMuchTime : MetroFramework.Forms.MetroForm
    {
        [DllImport("user32")]
        public static extern void LockWorkStation();

        [DllImport("PowrProf.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        public static extern bool SetSuspendState(bool hiberate, bool forceCritical, bool disableWakeEvent);


        int hours;
        int mins;
        int secs;
        string func;
        public AfterHowMuchTime(string function)
        {
            func = function;
            
            InitializeComponent();
           
             

        }
        public int getHours()
        {
            return hours; 
        }
        public int getMins()
        {
            return mins;
        }
        public int getSecs()
        {
            return secs;
        }

        private void AfterHowMuchTime_Load(object sender, EventArgs e)
        {
            
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            hours = Convert.ToInt32(HourTextBox.Text);

            mins = Convert.ToInt32(MinsTextBox.Text);

            secs = Convert.ToInt32(SecsTextBox.Text);

            int a = (hours * 60 * 60 * 1000) + (mins * 60 * 1000) + (secs * 1000);
            if (func.Equals("lock"))
            {
                
               
               
                var t = Task.Run(async delegate
                {
                    await Task.Delay(a);
                    return 0;
                });
                t.Wait();

                LockWorkStation();
                
            }
            if (func.Equals("shut"))
            {
                MessageBox.Show("The system will shut down now. Save all your tasks.");

                var t = Task.Run(async delegate
                {
                    await Task.Delay(a);
                    return 0;
                });
                t.Wait();
                Process.Start("shutdown", "/r /t a");            

            }

            if (func.Equals("sleep"))
            {
                var t = Task.Run(async delegate
                {
                    await Task.Delay(a);
                    return 0;
                });
                t.Wait();
                SetSuspendState(true, true, true);//hibernate
            }

            this.Close();
        }

        private void HourTextBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(HourTextBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                HourTextBox.Text = HourTextBox.Text.Remove(HourTextBox.Text.Length - 1);
            }
        }

        private void MinsTextBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(MinsTextBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                MinsTextBox.Text = MinsTextBox.Text.Remove(MinsTextBox.Text.Length - 1);
            }
        }

        private void SecsTextBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(SecsTextBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                SecsTextBox.Text = SecsTextBox.Text.Remove(SecsTextBox.Text.Length - 1);
            }
        }
    }
}
