using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IgenFinalVersion
{
    public partial class ReminderToAdd : MetroFramework.Forms.MetroForm
    {
        public ReminderToAdd()
        {
            InitializeComponent();
        }

        private void ReminderToAdd_Load(object sender, EventArgs e)
        {

        }

       public String getTextForm2()
        {
            return ToRemindTextbox.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
