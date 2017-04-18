using System;
using System.Windows.Forms;
using NAudio.Wave;
using Google.Cloud.Speech.V1;
using Google.Apis.Auth.OAuth2;
using System.Diagnostics;

namespace IgenFinalVersion
{
    public partial class GoogleEngine : MetroFramework.Forms.MetroForm
    {
        public GoogleEngine()
        {
            InitializeComponent();
        }

        //Instance Variables
        WaveIn sourceStream = null;
        WaveFileWriter waveWriter = null;

        System.Timers.Timer aTimer; // Timer to record the wav file
        System.Timers.Timer countDown; //Timer to play the countdown
        WaveInCapabilities microphone;

        Boolean wavRecorded = false;
        

        private void GoogleEngine_Load(object sender, EventArgs e)
        {
            //Find the device
            microphone = new WaveInCapabilities();
            Boolean microphoneDetected = true;

            for (int i=0;i<WaveIn.DeviceCount;i++)
            {
                if (WaveIn.GetCapabilities(i).ProductName.StartsWith("Microphone"))
                {
                    microphoneDetected = true;
                    Console.WriteLine("Microphone Detected");
                    microphone = WaveIn.GetCapabilities(i);
                    break;
                }
            }

            if (!microphoneDetected)
            {
                MessageBox.Show("No microphone found on your device. Search cannot proceed.");
                return;
            }
        }

        
        private void RecordButton_Click(object sender, EventArgs e)
        {
            string fileName = "C:/Users/PrAnk/Desktop/test.flac";   //Path of the wav file to be recorded into

            sourceStream = new WaveIn();
            sourceStream.WaveFormat = new WaveFormat(16000,1);
            sourceStream.DataAvailable += new EventHandler<WaveInEventArgs>(sourceStream_DataAvailable);
            waveWriter = new WaveFileWriter(fileName,sourceStream.WaveFormat);

            sourceStream.StartRecording();

            aTimer = new System.Timers.Timer();
            countDown = new System.Timers.Timer();

            countDown.Elapsed += new System.Timers.ElapsedEventHandler(startCountDown);
            countDown.Interval = 1000;
            countDown.Enabled = true;

            aTimer.Elapsed += new System.Timers.ElapsedEventHandler(onTimedEvent);
            aTimer.Interval = 6000;
            aTimer.Enabled = true;

        }

        int i = 0;
        private void startCountDown(object sender, EventArgs e)
        {
            i++;
            SetText(i+"");
            if (i==6)
            {
                aTimer.Enabled = false;
                countDown.Enabled = false;
                wavRecorded = true;
            }
        }

        //To make thread safe call to Window Forms Control
        delegate void SetTextCallback(String text);

        private void SetText (string text)
        {
            if (this.CountDownLabel.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
                this.CountDownLabel.Text = text;
        }

        private void onTimedEvent(object sender,EventArgs e)
        {
            sourceStream.StopRecording();
            sourceStream = null;
            
            waveWriter.Dispose();
            waveWriter = null;
            MessageBox.Show("recorded");
        }
        private void sourceStream_DataAvailable(object sender,WaveInEventArgs e)
        {
            if (waveWriter == null)
                return;

            waveWriter.Write(e.Buffer,0,e.BytesRecorded);
            waveWriter.Flush();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string credential_path = @"I:/IgenVoiceRecognition-4b16cb56bff4.json";
            System.Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", credential_path);
            var speech = SpeechClient.Create();
            var response = speech.Recognize(new RecognitionConfig() {
                Encoding = RecognitionConfig.Types.AudioEncoding.Linear16,
                SampleRateHertz = 16000,
                LanguageCode = "en",
            },RecognitionAudio.FromFile("C:/Users/PrAnk/Desktop/test.flac"));

            foreach (var result in response.Results)
            {
                foreach (var alternative in result.Alternatives)
                {
                    Process.Start("chrome",alternative.Transcript);
                }
            }
        }
    }
}
