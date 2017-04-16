using System;
using System.IO;
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
            
            //Available Space In Drives
            double spaceInCDrive = DriveSize("C:");
            double spaceInFDrive = DriveSize("F:");
            double spaceInIDrive = DriveSize("I:");

            //Start progress bar
            progress.Interval = 5000;
            progress.Tick += new EventHandler(this.startLoading);
            progress.Start();
            progress.Interval = 5;

        }

        double i = 0, j = 0, k = 0;
        private void startLoading (object sender, EventArgs e)
        {
            double spaceInCDrive = DriveSize("C:");
            double spaceInFDrive = DriveSize("F:");
            double spaceInIDrive = DriveSize("I:");

            i++;
            j++;
            k++;

            if (i<=spaceInCDrive)
            {
                spaceInCProgress.Value = (int)i;
            }
            if (j<=spaceInFDrive)
            {
                spaceInFProgress.Value = (int)j;
            }
            if (k <= spaceInIDrive)
            {
                spaceInIProgress.Value = (int)k;
            }

        }
        

        private double DriveSize(string path)
        {
            string drive = Directory.GetDirectoryRoot(path);
            DriveInfo d = new DriveInfo(drive);

            long FreeSize = d.AvailableFreeSpace;

            long totalSize = d.TotalSize;

            long fSize = FreeSize / 1000000000;
            long tSize = totalSize / 1000000000;

            double perUsed = ((double)(tSize - fSize) / (double)tSize) * 100;
            return perUsed;
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
