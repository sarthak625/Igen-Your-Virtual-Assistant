using System;
using NAudio.Wave;
using System.Windows.Forms;

namespace IgenFinalVersion
{
    public partial class ReminderFeature : MetroFramework.Forms.MetroForm
    {
        public ReminderFeature()
        {
            InitializeComponent();
        }

        private void ReminderFeature_Load(object sender, EventArgs e)
        {

        }
        WaveIn SourceStream = null;
        WaveFileWriter waveWriter = null;

        System.Timers.Timer aTimer;             //Timer to record the wav file
        System.Timers.Timer countDown;          //Timer to play the countdown

        Boolean wavRecorded = false;
        private void RecordButton_Click(object sender, EventArgs e)
        {
            WaveInCapabilities microphone = new WaveInCapabilities();
            Boolean microphoneDetected = false;

            for (int i = 0; i < WaveIn.DeviceCount; i++)
            {
                if (WaveIn.GetCapabilities(i).ProductName.StartsWith("Microphone"))
                {
                    microphoneDetected = true;
                    Console.WriteLine("Microphone detected");
                    microphone = WaveIn.GetCapabilities(i);
                    break;
                }
            }

            if (!microphoneDetected)
            {
                MessageBox.Show("No microphone detected in your machine");
                return;
            }

            String fileName = "I:/reminder.wav";

            SourceStream = new WaveIn();
            SourceStream.WaveFormat = new WaveFormat(44100, microphone.Channels);
            SourceStream.DataAvailable += new EventHandler<WaveInEventArgs>(sourceStream_DataAvailable);
            waveWriter = new WaveFileWriter(fileName, SourceStream.WaveFormat);

            SourceStream.StartRecording();

            aTimer = new System.Timers.Timer();
            countDown = new System.Timers.Timer();

            countDown.Elapsed += new System.Timers.ElapsedEventHandler(startCountDown);
            countDown.Interval = 1000;
            countDown.Enabled = true;

            aTimer.Elapsed += new System.Timers.ElapsedEventHandler(onTimedEvent);
            aTimer.Interval = 10000;
            aTimer.Enabled = true;

        }

        int i = 0;
        private void startCountDown(object sender, EventArgs e)
        {
            i++;
            SetText(i + "");
            if (i == 10)
            {
                aTimer.Enabled = false;
                countDown.Enabled = false;
                wavRecorded = true;
            }
        }

        //To make thread safe call to Window Forms Control
        delegate void SetTextCallback(String text);

        private void SetText(string text)
        {
            if (this.CountDownLabel.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
                this.CountDownLabel.Text = text;
        }

        System.Timers.Timer playTimer;
        private void onTimedEvent(object sender, EventArgs e)
        {
            SourceStream.StopRecording();
            
            SourceStream = null;
            waveWriter.Dispose();
            waveWriter = null;
         
            MessageBox.Show("recorded");
            int h = Convert.ToInt32(HourBox.Text);
            int m = Convert.ToInt32(MinBox.Text);
            int s = Convert.ToInt32(SecsBox.Text);

            int milliseconds = (h * 60 * 60 * 1000) + (m * 60 * 1000) + (s * 1000);
            if (milliseconds == 0)
            {
                PlayClass.playRecording();
            }
            else
            {
                playTimer = new System.Timers.Timer();                
                playTimer.Interval = milliseconds;
                playTimer.Elapsed += new System.Timers.ElapsedEventHandler(play);
                playTimer.Enabled = true;
            }
        }

        private void play (object sender, EventArgs e)
        {
            playTimer.Enabled = false;
            PlayClass.playRecording();
        }

       
        private void sourceStream_DataAvailable(object sender, WaveInEventArgs e)
        {
            if (waveWriter == null)
                return;

            waveWriter.Write(e.Buffer, 0, e.BytesRecorded);
            waveWriter.Flush();
        }

        string toAdd = null;
        private void RemindButton_Click(object sender, EventArgs e)
        {
            ReminderToAdd rta = new ReminderToAdd();
            rta.ShowDialog();
            toAdd = rta.getTextForm2();
            
            int h = Convert.ToInt32(HourBox.Text);
            int m = Convert.ToInt32(MinBox.Text);
            int s = Convert.ToInt32(SecsBox.Text);
            listBox1.Items.Add(toAdd + " ==> in ------->  " +h+" h "+m+" m "+s+ " s ");

            int milliseconds = (h * 60 * 60 * 1000) + (m * 60 * 1000) + (s * 1000);
            if (milliseconds == 0)
            {
                MessageBox.Show(toAdd);
            }
            else
            {
                playTimer = new System.Timers.Timer();
                playTimer.Interval = milliseconds;
                playTimer.Elapsed += new System.Timers.ElapsedEventHandler(remind);
                playTimer.Enabled = true;
            }
            
        }

        private void remind(object sender,EventArgs e)
        {
            MessageBox.Show(toAdd);
            playTimer.Enabled = false;
        }
    }

    public class PlayClass
    {
        private static BlockAlignReductionStream stream = null;    //Takes the uncompressed data and creates what appears to be a large block of uncompressed audio
        private static DirectSoundOut output = null;

        public static void playRecording()
        {
            DisposeWave();

            String fileName = "I:/reminder.wav";
            WaveStream pcm = new WaveChannel32(new WaveFileReader(fileName));
            stream = new BlockAlignReductionStream(pcm);

            output = new DirectSoundOut();
            output.Init(stream);
            output.Play();
        }

        private static void DisposeWave()
        {
            if (output != null)
            {
                if (output.PlaybackState == NAudio.Wave.PlaybackState.Playing)
                    output.Stop();

                output.Dispose();
                output = null;
            }
            if (stream != null)
            {
                stream.Dispose();
                stream = null;
            }
        }
    }
}