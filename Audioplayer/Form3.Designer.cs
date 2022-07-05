namespace Audioplayer
{
    partial class Form3
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
            this.deletePlaylistBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addSongsPlaylist = new System.Windows.Forms.Button();
            this.PlaylistSongsListbox = new System.Windows.Forms.CheckedListBox();
            this.delSongsPlaylist = new System.Windows.Forms.Button();
            this.updateName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AllsongListbox
            // 
            this.AllsongListbox.CheckOnClick = true;
            this.AllsongListbox.FormattingEnabled = true;
            this.AllsongListbox.Location = new System.Drawing.Point(281, 84);
            this.AllsongListbox.Name = "AllsongListbox";
            this.AllsongListbox.Size = new System.Drawing.Size(203, 304);
            this.AllsongListbox.TabIndex = 0;
            // 
            // deletePlaylistBtn
            // 
            this.deletePlaylistBtn.BackColor = System.Drawing.Color.IndianRed;
            this.deletePlaylistBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.deletePlaylistBtn.Location = new System.Drawing.Point(421, 474);
            this.deletePlaylistBtn.Name = "deletePlaylistBtn";
            this.deletePlaylistBtn.Size = new System.Drawing.Size(90, 23);
            this.deletePlaylistBtn.TabIndex = 1;
            this.deletePlaylistBtn.Text = "Delete Playlist";
            this.deletePlaylistBtn.UseVisualStyleBackColor = false;
            this.deletePlaylistBtn.Click += new System.EventHandler(this.deletePlaylistBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(194, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(159, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Playlist Name";
            // 
            // addSongsPlaylist
            // 
            this.addSongsPlaylist.Location = new System.Drawing.Point(328, 434);
            this.addSongsPlaylist.Name = "addSongsPlaylist";
            this.addSongsPlaylist.Size = new System.Drawing.Size(106, 23);
            this.addSongsPlaylist.TabIndex = 4;
            this.addSongsPlaylist.Text = "Add files to playlist";
            this.addSongsPlaylist.UseVisualStyleBackColor = true;
            this.addSongsPlaylist.Click += new System.EventHandler(this.button2_Click);
            // 
            // PlaylistSongsListbox
            // 
            this.PlaylistSongsListbox.CheckOnClick = true;
            this.PlaylistSongsListbox.FormattingEnabled = true;
            this.PlaylistSongsListbox.Location = new System.Drawing.Point(36, 84);
            this.PlaylistSongsListbox.Name = "PlaylistSongsListbox";
            this.PlaylistSongsListbox.Size = new System.Drawing.Size(205, 304);
            this.PlaylistSongsListbox.TabIndex = 5;
            // 
            // delSongsPlaylist
            // 
            this.delSongsPlaylist.Location = new System.Drawing.Point(70, 434);
            this.delSongsPlaylist.Name = "delSongsPlaylist";
            this.delSongsPlaylist.Size = new System.Drawing.Size(136, 23);
            this.delSongsPlaylist.TabIndex = 6;
            this.delSongsPlaylist.Text = "Remove files from playlist";
            this.delSongsPlaylist.UseVisualStyleBackColor = true;
            this.delSongsPlaylist.Click += new System.EventHandler(this.delSongsPlaylist_Click);
            // 
            // updateName
            // 
            this.updateName.Location = new System.Drawing.Point(363, 36);
            this.updateName.Name = "updateName";
            this.updateName.Size = new System.Drawing.Size(136, 23);
            this.updateName.TabIndex = 7;
            this.updateName.Text = "Update Name";
            this.updateName.UseVisualStyleBackColor = true;
            this.updateName.Click += new System.EventHandler(this.updateName_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 499);
            this.Controls.Add(this.updateName);
            this.Controls.Add(this.delSongsPlaylist);
            this.Controls.Add(this.PlaylistSongsListbox);
            this.Controls.Add(this.addSongsPlaylist);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.deletePlaylistBtn);
            this.Controls.Add(this.AllsongListbox);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox AllsongListbox;
        private System.Windows.Forms.Button deletePlaylistBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addSongsPlaylist;
        private System.Windows.Forms.CheckedListBox PlaylistSongsListbox;
        private System.Windows.Forms.Button delSongsPlaylist;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button updateName;
    }
}