namespace Harmonic_Ferret
{
    partial class Form1
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
            listBoxSongs = new ListBox();
            BtnPlayPause = new Button();
            btnSelSongs = new Button();
            barAudioTime = new ProgressBar();
            SuspendLayout();
            // 
            // listBoxSongs
            // 
            listBoxSongs.AllowDrop = true;
            listBoxSongs.BackColor = Color.FromArgb(28, 48, 81);
            listBoxSongs.Font = new Font("Microsoft YaHei UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            listBoxSongs.FormattingEnabled = true;
            listBoxSongs.ItemHeight = 38;
            listBoxSongs.Location = new Point(0, 0);
            listBoxSongs.Name = "listBoxSongs";
            listBoxSongs.Size = new Size(1265, 536);
            listBoxSongs.TabIndex = 0;
            listBoxSongs.SelectedIndexChanged += listBoxSongs_SelectedIndexChanged;
            // 
            // BtnPlayPause
            // 
            BtnPlayPause.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnPlayPause.Location = new Point(890, 397);
            BtnPlayPause.Name = "BtnPlayPause";
            BtnPlayPause.Size = new Size(362, 119);
            BtnPlayPause.TabIndex = 2;
            BtnPlayPause.Text = "Play/Pause";
            BtnPlayPause.UseVisualStyleBackColor = true;
            BtnPlayPause.Click += BtnPlayPause_Click;
            // 
            // btnSelSongs
            // 
            btnSelSongs.Location = new Point(12, 403);
            btnSelSongs.Name = "btnSelSongs";
            btnSelSongs.Size = new Size(362, 109);
            btnSelSongs.TabIndex = 4;
            btnSelSongs.Text = "Select";
            btnSelSongs.UseVisualStyleBackColor = true;
            btnSelSongs.Click += button1_Click;
            // 
            // barAudioTime
            // 
            barAudioTime.BackColor = Color.FromArgb(22, 22, 22);
            barAudioTime.ForeColor = Color.White;
            barAudioTime.Location = new Point(282, 607);
            barAudioTime.Name = "barAudioTime";
            barAudioTime.Size = new Size(695, 21);
            barAudioTime.TabIndex = 5;
            // 
            // Form1
            // 
            BackColor = Color.FromArgb(42, 42, 54);
            ClientSize = new Size(1264, 681);
            Controls.Add(barAudioTime);
            Controls.Add(btnSelSongs);
            Controls.Add(BtnPlayPause);
            Controls.Add(listBoxSongs);
            Name = "Form1";
            Text = "Harmonic Ferret";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxSongs;
        private Button BtnPlayPause;
        private Button btnSelSongs;
        private ProgressBar barAudioTime;
    }
}