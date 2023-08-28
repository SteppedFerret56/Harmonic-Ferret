using NAudio.Wave;
using System;
using System.IO;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Harmonic_Ferret
{
    public partial class Form1 : Form
    {

        [DllImport("kernel32.dll")]
        private static extern bool AllocConsole();
        private DirectSoundOut output;
        private WaveStream audioFileStream;
        private System.Windows.Forms.Timer barAudioTimeTimer = new System.Windows.Forms.Timer();

        public Form1()
        {
            InitializeComponent();

            // Set up the timer
            barAudioTimeTimer.Interval = 1000; // 1 second interval
            barAudioTimeTimer.Tick += barAudioTime_Tick;

            AllocConsole(); // Allocate a console window
        }


        String[] paths, files;


        private void BtnPlayPause_Click(object sender, EventArgs e)
        {
            if (output != null)
            {
                if (output.PlaybackState == PlaybackState.Playing) output.Pause();
                else if (output.PlaybackState == PlaybackState.Paused) output.Play();
            }
        }


        private void listBoxSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxSongs.SelectedIndex >= 0 && listBoxSongs.SelectedIndex < paths.Length)
            {
                string selectedFilePath = paths[listBoxSongs.SelectedIndex];
                Console.WriteLine("Selected file path: " + selectedFilePath);
                StopAudio();
                PlayAudio(selectedFilePath);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "Audio Files|*.wav;*.mp3",
                Multiselect = true,
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (files == null || paths == null)
                {
                    files = new string[0];
                    paths = new string[0];
                }

                files = files.Concat(ofd.SafeFileNames).ToArray();
                paths = paths.Concat(ofd.FileNames).ToArray();

                for (int i = listBoxSongs.Items.Count; i < files.Length; i++)
                {
                    listBoxSongs.Items.Add(files[i]);
                }

                if (listBoxSongs.Items.Count > 0)
                {
                    listBoxSongs.SelectedIndex = 0; // Select the first item
                }
            }
        }

        private void PlayAudio(string filePath)
        {
            StopAudio(); // Dispose of any previous audio resources

            string fileExtension = Path.GetExtension(filePath).ToLower();

            switch (fileExtension)
            {
                case ".wav":
                    audioFileStream = new WaveFileReader(filePath);
                    output = new DirectSoundOut();
                    output.Init(new WaveChannel32((WaveFileReader)audioFileStream));
                    output.Play();
                    barAudioTimeTimer.Start(); // Start timer for progress bar
                    break;

                case ".mp3":
                    audioFileStream = new Mp3FileReader(filePath);
                    output = new DirectSoundOut();
                    output.Init(new WaveChannel32(audioFileStream));
                    output.Play();
                    barAudioTimeTimer.Start(); // Start timer for progress bar
                    break;

                default:
                    // Handle unsupported file types
                    break;
            }
        }


        private void barAudioTime_Tick(object sender, EventArgs e)
        {
            if (output != null && output.PlaybackState == PlaybackState.Playing)
            {
                double currentTime = audioFileStream.CurrentTime.TotalSeconds;
                double totalAudioLength = audioFileStream.TotalTime.TotalSeconds;

                // Calculate progress as a percentage
                int progressPercentage = (int)((currentTime / totalAudioLength) * 100);

                // Update progress bar value
                barAudioTime.Value = progressPercentage;
            }
        }

        private void StopAudio()
        {
            if (output != null)
            {
                if (output.PlaybackState == PlaybackState.Playing)
                {
                    output.Stop();
                }
                output.Dispose();
                output = null;
            }

            if (audioFileStream != null)
            {
                audioFileStream.Dispose();
                audioFileStream = null;
            }

            barAudioTimeTimer.Stop(); // Stop timer when audio playback stops
            barAudioTime.Value = 0;   // Reset progress bar value
        }
    }
}