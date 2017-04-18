using System;
using System.IO;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Speech;
using System.Speech.Recognition;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Threading.Tasks;

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

        /* -------------------------------- Voice Recognition --------------------------------  */


        //Initialization Of Variables Required For Speech
        SpeechSynthesizer ss = new SpeechSynthesizer();
        PromptBuilder pb = new PromptBuilder();
        SpeechRecognitionEngine sre = new SpeechRecognitionEngine();
        Choices cList = new Choices();
        String[] options;

        //Added start button
        Boolean isEnabled = false;
        private void StartButton_Click(object sender, EventArgs e)
        {
            if (!isEnabled)     //If start button is not already enabled start voice recognition
            {
                isEnabled = true;
                StartButton.Text = "Stop";
                ListenerLabel.Visible = true;
                startRecognition();
            }
            else if (isEnabled)      //If start button is enabled stop voice recognition
            {
                sre.RecognizeAsyncStop();
                
                StartButton.Text = "Start";
                ListenerLabel.Visible = false;
                isEnabled = false;
            }
            else
            { }        
        }


        

        private void startRecognition()
        {
            options = new String[] { "open command prompt", "good morning", "good evening", "good night", "good afternoon","activate google engine","hi","hello","introduce yourself","igen lock the screen", "igen shut down the computer","activate reminder feature", "igen make the computer sleep" ,"open chrome","open notepad"};
            cList.Add(options);
            Grammar gr = new Grammar(new GrammarBuilder(cList));

            try
            {
                sre.RequestRecognizerUpdate();
                sre.LoadGrammar(gr);
                sre.SpeechRecognized += sre_SpeechRecognized;
                sre.SetInputToDefaultAudioDevice();
                sre.RecognizeAsync(RecognizeMode.Multiple);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            ss.SelectVoiceByHints(VoiceGender.Female);
            
    
        }

        int a = 0;
        
                        
        private void sre_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            switch (e.Result.Text.ToString())
            {
                case "open command prompt":
                    {
                        Process.Start("cmd");
                        break;
                    }
                case "open chrome":
                    {
                        Process.Start("chrome");
                        break;
                    }
                case "open notepad":
                    {
                        Process.Start("notepad");
                        break;
                    }
                case "activate google engine":
                    {
                        ss.SpeakAsync("Google Engine Online");
                        GoogleEngine ge = new GoogleEngine();
                        ge.Activated += new EventHandler(GoogleFormActivated);                 
                        ge.ShowDialog();
                        
                        break;
                    }
                case "activate reminder feature":
                    {
                        ss.SpeakAsync("Reminder feature activated");
                        ReminderFeature rf = new ReminderFeature();
                        rf.Activated += new EventHandler(ReminderFeatureActivated);
                        rf.ShowDialog();
                        break;
                    }
                case "good morning":
                case "good evening":
                case "good afternoon":
                case "good night":
                    {
                        DateTime d = DateTime.Now;
                        int h = d.Hour;

                        if (h < 12)
                            ss.SpeakAsync("Good Morning");
                        else if (h < 14)
                            ss.SpeakAsync("Good Afternoon");
                        else if (h < 20)
                            ss.SpeakAsync("Good Evening");
                        else
                            ss.SpeakAsync("Good Night");
                        break;
                    }
                case "igen lock the screen":
                    {
                        
                        using (AfterHowMuchTime ahmt = new AfterHowMuchTime("lock"))
                        {                          
                            ahmt.ShowDialog();
                        }
                        
                        
                        break;
                    }
                case "igen shut down the computer":
                    {
                        using (AfterHowMuchTime ahmt = new AfterHowMuchTime("shut"))
                        {
                            ahmt.ShowDialog();
                        }
                        break;
                    }
                case "igen make the computer sleep":
                    {
                        using (AfterHowMuchTime ahmt = new AfterHowMuchTime("sleep"))
                        {
                            ahmt.ShowDialog();
                        }
                        break;
                    }
                case "hi":
                case "hello":
                    {
                        Random random = new Random();
                        int rand = random.Next(0, 3);
                        if (rand == 0)
                        {
                            ss.SpeakAsync("Hey there, How can i help you today?");
                        }                 

                        else if (rand == 1)
                            ss.SpeakAsync("Hey. Wonderful day isnt it ");
                        else
                            ss.SpeakAsync("Yes, what can i do for you?");
                        
                        break;
                    }

                case "introduce yourself":
                    {
                        ss.SpeakAsync("My name is Igen. I am designed to ease up your daily tasks.");
                        break;
                    }
            }

            ConvoBox.Items.Add(e.Result.Text.ToString());
            
        }   
        
        private void GoogleFormActivated(object sender,EventArgs e)
        {
            sre.RecognizeAsyncStop();
            StartButton.Text = "Start";
            ListenerLabel.Visible = false;
            isEnabled = false;

        }

        private void ReminderFeatureActivated(object sender,EventArgs e)
        {
            sre.RecognizeAsyncStop();
            StartButton.Text = "Start";
            ListenerLabel.Visible = false;
            isEnabled = false;

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

        private void GEButton_Click(object sender, EventArgs e)
        {
            ss.SpeakAsync("Google Engine Online");
            GoogleEngine ge = new GoogleEngine();
            ge.Activated += new EventHandler(GoogleFormActivated);
            ge.ShowDialog();
        }

        private void RFButton_Click(object sender, EventArgs e)
        {
            ss.SpeakAsync("Reminder feature activated");
            ReminderFeature rf = new ReminderFeature();
            rf.Activated += new EventHandler(ReminderFeatureActivated);
            rf.ShowDialog();
        }

        private void Igen_Load(object sender, EventArgs e)
        {
            
        }

        //Windows Events
       

        [DllImport("user32")]
        public static extern bool ExitWindowsEx(uint uFlags, uint dwReason);

        


    }
}
