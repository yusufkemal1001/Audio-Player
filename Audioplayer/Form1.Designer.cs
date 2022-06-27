
namespace Audioplayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.AllsongListbox = new System.Windows.Forms.CheckedListBox();
            this.QueueListbox = new System.Windows.Forms.ListBox();
            this.queueRadio = new System.Windows.Forms.RadioButton();
            this.allSongsRadio = new System.Windows.Forms.RadioButton();
            this.Upload = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.mediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.openPlaylist = new System.Windows.Forms.Button();
            this.NextSongBtn = new System.Windows.Forms.Button();
            this.PrevSongBtn = new System.Windows.Forms.Button();
            this.PlayBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // AllsongListbox
            // 
            this.AllsongListbox.FormattingEnabled = true;
            this.AllsongListbox.Location = new System.Drawing.Point(449, 46);
            this.AllsongListbox.Name = "AllsongListbox";
            this.AllsongListbox.Size = new System.Drawing.Size(169, 379);
            this.AllsongListbox.TabIndex = 3;
            this.AllsongListbox.SelectedIndexChanged += new System.EventHandler(this.AllsongListbox_SelectedIndexChanged);
            // 
            // QueueListbox
            // 
            this.QueueListbox.FormattingEnabled = true;
            this.QueueListbox.Location = new System.Drawing.Point(624, 46);
            this.QueueListbox.Name = "QueueListbox";
            this.QueueListbox.Size = new System.Drawing.Size(168, 381);
            this.QueueListbox.TabIndex = 4;
            this.QueueListbox.SelectedIndexChanged += new System.EventHandler(this.QueueListbox_SelectedIndexChanged);
            // 
            // queueRadio
            // 
            this.queueRadio.AutoSize = true;
            this.queueRadio.Location = new System.Drawing.Point(730, 12);
            this.queueRadio.Name = "queueRadio";
            this.queueRadio.Size = new System.Drawing.Size(57, 17);
            this.queueRadio.TabIndex = 5;
            this.queueRadio.Text = "Queue";
            this.queueRadio.UseVisualStyleBackColor = true;
            this.queueRadio.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // allSongsRadio
            // 
            this.allSongsRadio.AutoSize = true;
            this.allSongsRadio.Checked = true;
            this.allSongsRadio.Location = new System.Drawing.Point(619, 12);
            this.allSongsRadio.Name = "allSongsRadio";
            this.allSongsRadio.Size = new System.Drawing.Size(69, 17);
            this.allSongsRadio.TabIndex = 7;
            this.allSongsRadio.TabStop = true;
            this.allSongsRadio.Text = "All Songs";
            this.allSongsRadio.UseVisualStyleBackColor = true;
            this.allSongsRadio.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // Upload
            // 
            this.Upload.Location = new System.Drawing.Point(717, 455);
            this.Upload.Name = "Upload";
            this.Upload.Size = new System.Drawing.Size(75, 23);
            this.Upload.TabIndex = 8;
            this.Upload.Text = "Upload";
            this.Upload.UseVisualStyleBackColor = true;
            this.Upload.Click += new System.EventHandler(this.Upload_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(449, 455);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(368, 455);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // mediaPlayer
            // 
            this.mediaPlayer.Enabled = true;
            this.mediaPlayer.Location = new System.Drawing.Point(36, 46);
            this.mediaPlayer.Name = "mediaPlayer";
            this.mediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mediaPlayer.OcxState")));
            this.mediaPlayer.Size = new System.Drawing.Size(379, 343);
            this.mediaPlayer.TabIndex = 9;
            this.mediaPlayer.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter_1);
            // 
            // openPlaylist
            // 
            this.openPlaylist.Location = new System.Drawing.Point(47, 455);
            this.openPlaylist.Name = "openPlaylist";
            this.openPlaylist.Size = new System.Drawing.Size(75, 23);
            this.openPlaylist.TabIndex = 12;
            this.openPlaylist.Text = "Playlists";
            this.openPlaylist.UseVisualStyleBackColor = true;
            this.openPlaylist.Click += new System.EventHandler(this.openPlaylist_Click);
            // 
            // NextSongBtn
            // 
            this.NextSongBtn.BackgroundImage = global::Audioplayer.Properties.Resources.next;
            this.NextSongBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NextSongBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.NextSongBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.NextSongBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.NextSongBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextSongBtn.Location = new System.Drawing.Point(93, 412);
            this.NextSongBtn.Name = "NextSongBtn";
            this.NextSongBtn.Size = new System.Drawing.Size(29, 26);
            this.NextSongBtn.TabIndex = 1;
            this.NextSongBtn.UseVisualStyleBackColor = true;
            this.NextSongBtn.Click += new System.EventHandler(this.NextSongBtn_Click_1);
            // 
            // PrevSongBtn
            // 
            this.PrevSongBtn.BackgroundImage = global::Audioplayer.Properties.Resources.left_arrow;
            this.PrevSongBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PrevSongBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.PrevSongBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.PrevSongBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.PrevSongBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrevSongBtn.Location = new System.Drawing.Point(36, 412);
            this.PrevSongBtn.Name = "PrevSongBtn";
            this.PrevSongBtn.Size = new System.Drawing.Size(29, 26);
            this.PrevSongBtn.TabIndex = 2;
            this.PrevSongBtn.UseVisualStyleBackColor = true;
            this.PrevSongBtn.Click += new System.EventHandler(this.PrevSongBtn_Click);
            // 
            // PlayBtn
            // 
            this.PlayBtn.BackgroundImage = global::Audioplayer.Properties.Resources.play_buttton;
            this.PlayBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PlayBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.PlayBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.PlayBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.PlayBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayBtn.Location = new System.Drawing.Point(71, 412);
            this.PlayBtn.Name = "PlayBtn";
            this.PlayBtn.Size = new System.Drawing.Size(25, 26);
            this.PlayBtn.TabIndex = 0;
            this.PlayBtn.UseVisualStyleBackColor = true;
            this.PlayBtn.Click += new System.EventHandler(this.PlayBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 490);
            this.Controls.Add(this.openPlaylist);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mediaPlayer);
            this.Controls.Add(this.Upload);
            this.Controls.Add(this.PlayBtn);
            this.Controls.Add(this.allSongsRadio);
            this.Controls.Add(this.queueRadio);
            this.Controls.Add(this.QueueListbox);
            this.Controls.Add(this.AllsongListbox);
            this.Controls.Add(this.PrevSongBtn);
            this.Controls.Add(this.NextSongBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckedListBox AllsongListbox;
        private System.Windows.Forms.ListBox QueueListbox;
        private System.Windows.Forms.RadioButton queueRadio;
        private System.Windows.Forms.RadioButton allSongsRadio;
        private System.Windows.Forms.Button Upload;
        private AxWMPLib.AxWindowsMediaPlayer mediaPlayer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button openPlaylist;
        private System.Windows.Forms.Button NextSongBtn;
        private System.Windows.Forms.Button PrevSongBtn;
        private System.Windows.Forms.Button PlayBtn;
    }
}

