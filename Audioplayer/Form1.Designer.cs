
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
            this.AllsongListbox = new System.Windows.Forms.CheckedListBox();
            this.QueueListbox = new System.Windows.Forms.ListBox();
            this.queueRadio = new System.Windows.Forms.RadioButton();
            this.allSongsRadio = new System.Windows.Forms.RadioButton();
            this.PrevSongBtn = new System.Windows.Forms.Button();
            this.NextSongBtn = new System.Windows.Forms.Button();
            this.PlayBtn = new System.Windows.Forms.Button();
            this.Upload = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AllsongListbox
            // 
            this.AllsongListbox.FormattingEnabled = true;
            this.AllsongListbox.Location = new System.Drawing.Point(619, 46);
            this.AllsongListbox.Name = "AllsongListbox";
            this.AllsongListbox.Size = new System.Drawing.Size(169, 364);
            this.AllsongListbox.TabIndex = 3;
            // 
            // QueueListbox
            // 
            this.QueueListbox.FormattingEnabled = true;
            this.QueueListbox.Location = new System.Drawing.Point(445, 46);
            this.QueueListbox.Name = "QueueListbox";
            this.QueueListbox.Size = new System.Drawing.Size(168, 368);
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
            // Upload
            // 
            this.Upload.Location = new System.Drawing.Point(225, 178);
            this.Upload.Name = "Upload";
            this.Upload.Size = new System.Drawing.Size(75, 23);
            this.Upload.TabIndex = 8;
            this.Upload.Text = "Upload";
            this.Upload.UseVisualStyleBackColor = true;
            this.Upload.Click += new System.EventHandler(this.Upload_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PlayBtn;
        private System.Windows.Forms.Button NextSongBtn;
        private System.Windows.Forms.Button PrevSongBtn;
        private System.Windows.Forms.CheckedListBox AllsongListbox;
        private System.Windows.Forms.ListBox QueueListbox;
        private System.Windows.Forms.RadioButton queueRadio;
        private System.Windows.Forms.RadioButton allSongsRadio;
        private System.Windows.Forms.Button Upload;
    }
}

