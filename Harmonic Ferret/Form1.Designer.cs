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
            this.listBoxSongs = new System.Windows.Forms.ListBox();
            this.BtnPlayPause = new System.Windows.Forms.Button();
            this.btnSelSongs = new System.Windows.Forms.Button();
            this.barAudioTime = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // listBoxSongs
            // 
            this.listBoxSongs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(48)))), ((int)(((byte)(81)))));
            this.listBoxSongs.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxSongs.FormattingEnabled = true;
            this.listBoxSongs.ItemHeight = 38;
            this.listBoxSongs.Location = new System.Drawing.Point(0, 0);
            this.listBoxSongs.Name = "listBoxSongs";
            this.listBoxSongs.Size = new System.Drawing.Size(1265, 536);
            this.listBoxSongs.TabIndex = 0;
            this.listBoxSongs.SelectedIndexChanged += new System.EventHandler(this.listBoxSongs_SelectedIndexChanged);
            // 
            // BtnPlayPause
            // 
            this.BtnPlayPause.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPlayPause.Location = new System.Drawing.Point(890, 397);
            this.BtnPlayPause.Name = "BtnPlayPause";
            this.BtnPlayPause.Size = new System.Drawing.Size(362, 119);
            this.BtnPlayPause.TabIndex = 2;
            this.BtnPlayPause.Text = "Play/Pause";
            this.BtnPlayPause.UseVisualStyleBackColor = true;
            this.BtnPlayPause.Click += new System.EventHandler(this.BtnPlayPause_Click);
            // 
            // btnSelSongs
            // 
            this.btnSelSongs.Location = new System.Drawing.Point(12, 403);
            this.btnSelSongs.Name = "btnSelSongs";
            this.btnSelSongs.Size = new System.Drawing.Size(362, 109);
            this.btnSelSongs.TabIndex = 4;
            this.btnSelSongs.Text = "Select";
            this.btnSelSongs.UseVisualStyleBackColor = true;
            this.btnSelSongs.Click += new System.EventHandler(this.button1_Click);
            // 
            // barAudioTime
            // 
            this.barAudioTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.barAudioTime.ForeColor = System.Drawing.Color.White;
            this.barAudioTime.Location = new System.Drawing.Point(282, 607);
            this.barAudioTime.Name = "barAudioTime";
            this.barAudioTime.Size = new System.Drawing.Size(695, 21);
            this.barAudioTime.TabIndex = 5;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.barAudioTime);
            this.Controls.Add(this.btnSelSongs);
            this.Controls.Add(this.BtnPlayPause);
            this.Controls.Add(this.listBoxSongs);
            this.Name = "Form1";
            this.Text = "Harmonic Ferret";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxSongs;
        private System.Windows.Forms.Button BtnPlayPause;
        private System.Windows.Forms.Button btnSelSongs;
        private System.Windows.Forms.ProgressBar barAudioTime;
    }
}