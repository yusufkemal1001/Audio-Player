
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
            this.addToQueueBtn = new System.Windows.Forms.Button();
            this.openPlaylist = new System.Windows.Forms.Button();
            this.mediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.PlaylistListbox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // AllsongListbox
            // 
            this.AllsongListbox.CheckOnClick = true;
            this.AllsongListbox.FormattingEnabled = true;
            this.AllsongListbox.Location = new System.Drawing.Point(449, 48);
            this.AllsongListbox.Name = "AllsongListbox";
            this.AllsongListbox.Size = new System.Drawing.Size(169, 379);
            this.AllsongListbox.TabIndex = 3;
            this.AllsongListbox.SelectedIndexChanged += new System.EventHandler(this.AllsongListbox_SelectedIndexChanged);
            // 
            // QueueListbox
            // 
            this.QueueListbox.FormattingEnabled = true;
            this.QueueListbox.Location = new System.Drawing.Point(636, 48);
            this.QueueListbox.Name = "QueueListbox";
            this.QueueListbox.Size = new System.Drawing.Size(168, 381);
            this.QueueListbox.TabIndex = 4;
            this.QueueListbox.SelectedIndexChanged += new System.EventHandler(this.QueueListbox_SelectedIndexChanged);
            // 
            // queueRadio
            // 
            this.queueRadio.AutoSize = true;
            this.queueRadio.Location = new System.Drawing.Point(524, 12);
            this.queueRadio.Name = "queueRadio";
            this.queueRadio.Size = new System.Drawing.Size(62, 17);
            this.queueRadio.TabIndex = 5;
            this.queueRadio.Text = "Playlists";
            this.queueRadio.UseVisualStyleBackColor = true;
            this.queueRadio.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // allSongsRadio
            // 
            this.allSongsRadio.AutoSize = true;
            this.allSongsRadio.Checked = true;
            this.allSongsRadio.Location = new System.Drawing.Point(449, 12);
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
            // addToQueueBtn
            // 
            this.addToQueueBtn.Location = new System.Drawing.Point(368, 455);
            this.addToQueueBtn.Name = "addToQueueBtn";
            this.addToQueueBtn.Size = new System.Drawing.Size(75, 23);
            this.addToQueueBtn.TabIndex = 11;
            this.addToQueueBtn.Text = "+ Queue";
            this.addToQueueBtn.UseVisualStyleBackColor = true;
            this.addToQueueBtn.Click += new System.EventHandler(this.addToQueueBtn_Click);
            // 
            // openPlaylist
            // 
            this.openPlaylist.Location = new System.Drawing.Point(47, 455);
            this.openPlaylist.Name = "openPlaylist";
            this.openPlaylist.Size = new System.Drawing.Size(91, 23);
            this.openPlaylist.TabIndex = 12;
            this.openPlaylist.Text = "Update Playlists";
            this.openPlaylist.UseVisualStyleBackColor = true;
            this.openPlaylist.Click += new System.EventHandler(this.openPlaylist_Click);
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
            // PlaylistListbox
            // 
            this.PlaylistListbox.FormattingEnabled = true;
            this.PlaylistListbox.Location = new System.Drawing.Point(450, 48);
            this.PlaylistListbox.Name = "PlaylistListbox";
            this.PlaylistListbox.Size = new System.Drawing.Size(168, 381);
            this.PlaylistListbox.TabIndex = 13;
            this.PlaylistListbox.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 490);
            this.Controls.Add(this.PlaylistListbox);
            this.Controls.Add(this.openPlaylist);
            this.Controls.Add(this.addToQueueBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mediaPlayer);
            this.Controls.Add(this.Upload);
            this.Controls.Add(this.allSongsRadio);
            this.Controls.Add(this.queueRadio);
            this.Controls.Add(this.QueueListbox);
            this.Controls.Add(this.AllsongListbox);
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
        private System.Windows.Forms.Button addToQueueBtn;
        private System.Windows.Forms.Button openPlaylist;
        private System.Windows.Forms.ListBox PlaylistListbox;
    }
}

