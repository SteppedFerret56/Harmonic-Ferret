using NAudio.Wave;
using System;
using System.Data.Odbc;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Harmonic_Ferret
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Song List & File open

        String[] paths, files;

        private NAudio.Wave.WaveFileReader wave = null;

        private NAudio.Wave.DirectSoundOut output = null;

        private void BtnPlayPause_Click(object sender, EventArgs e)
        {
            if (output != null)
            {
                if (output.PlaybackState == NAudio.Wave.PlaybackState.Playing) output.Pause();
                else if (output.PlaybackState == NAudio.Wave.PlaybackState.Paused) output.Play();
            }
        }

        private void listBoxSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxSongs.SelectedIndex >= 0)
            {
                string selectedFilePath = paths[listBoxSongs.SelectedIndex];
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
                files = ofd.SafeFileNames;
                paths = ofd.FileNames;
                for (int i = 0; i < files.Length; i++)
                {
                    listBoxSongs.Items.Add(files[i]);
                }

                string selectedFilePath = paths[0]; // Select the first file in the selection
                PlayAudio(selectedFilePath);
            }
        }

        private void PlayAudio(string filePath)
        {
            StopAudio(); // Dispose of any previous audio resources

            string fileExtension = Path.GetExtension(filePath).ToLower();

            switch (fileExtension)
            {
                case ".wav":
                    wave = new NAudio.Wave.WaveFileReader(filePath);
                    if (wave != null)
                    {
                        output = new NAudio.Wave.DirectSoundOut();
                        if (output != null)
                        {
                            output.Init(new NAudio.Wave.WaveChannel32(wave));
                            output.Play();
                        }
                    }
                    break;

                case ".mp3":
                    var reader = new Mp3FileReader(filePath);
                    if (reader != null)
                    {
                        output = new NAudio.Wave.DirectSoundOut();
                        if (output != null)
                        {
                            output.Init(reader);
                            output.Play();
                        }
                    }
                    break;

                default:
                    // Handle unsupported file types
                    break;
            }

            BtnPlayPause.Enabled = true;
        }

        private void barAudioTime_Tick(object sender, EventArgs e)
        {
            if (output != null && output.PlaybackState == NAudio.Wave.PlaybackState.Playing)
            {
                barAudioTime.Value = (int)wave.CurrentTime.TotalSeconds;
            }
        }

        private void StopAudio()
        {
            if (output != null)
            {
                if (output.PlaybackState == NAudio.Wave.PlaybackState.Playing)
                {
                    output.Stop();
                }
                output.Dispose();
                output = null;
            }

            if (wave != null)
            {
                wave.Dispose();
                wave = null;
            }
        }
    }
}
