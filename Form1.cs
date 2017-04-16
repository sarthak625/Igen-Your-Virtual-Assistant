using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IgenFinalVersion
{
    public partial class Igen : MetroFramework.Forms.MetroForm
    {
        Timer t = new Timer();      //Timer for date
        Timer progress = new Timer();

        public Igen()
        {
            //Initializes the components
            InitializeComponent();

            #region dateTime timer
            t.Interval = 1000;
            t.Tick += new EventHandler(this.t_tick);
            t.Start();
            #endregion
        }
        
        
        private void t_tick(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            String timeOnly = DateTime.Now.ToString("HH:mm:ss tt");
            TimeBlock.Text = timeOnly;
            string dateOnly = DateTime.Now.ToString("dd/MM/yy");
            string dayOfWeek = DateTime.Now.DayOfWeek.ToString();

            dateOnly += " "+dayOfWeek;
            DateBlock.Text = dateOnly;
        }

        private void Igen_Load(object sender, EventArgs e)
        {
            
        }
        

    }
}
