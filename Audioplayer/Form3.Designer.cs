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
            this.dataGridViewPlaylistSongs = new System.Windows.Forms.DataGridView();
            this.createPlaylist = new System.Windows.Forms.Button();
            this.playlistName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlaylistSongs)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPlaylistSongs
            // 
            this.dataGridViewPlaylistSongs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPlaylistSongs.Location = new System.Drawing.Point(43, 118);
            this.dataGridViewPlaylistSongs.Name = "dataGridViewPlaylistSongs";
            this.dataGridViewPlaylistSongs.ReadOnly = true;
            this.dataGridViewPlaylistSongs.Size = new System.Drawing.Size(293, 281);
            this.dataGridViewPlaylistSongs.TabIndex = 2;
            // 
            // createPlaylist
            // 
            this.createPlaylist.Location = new System.Drawing.Point(144, 419);
            this.createPlaylist.Name = "createPlaylist";
            this.createPlaylist.Size = new System.Drawing.Size(103, 23);
            this.createPlaylist.TabIndex = 3;
            this.createPlaylist.Text = "Create Playlist";
            this.createPlaylist.UseVisualStyleBackColor = true;
            this.createPlaylist.Click += new System.EventHandler(this.createPlaylist_Click);
            // 
            // playlistName
            // 
            this.playlistName.AutoSize = true;
            this.playlistName.Location = new System.Drawing.Point(50, 66);
            this.playlistName.Name = "playlistName";
            this.playlistName.Size = new System.Drawing.Size(70, 13);
            this.playlistName.TabIndex = 0;
            this.playlistName.Text = "Playlist Name";
            this.playlistName.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(144, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(192, 20);
            this.textBox1.TabIndex = 1;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 499);
            this.Controls.Add(this.createPlaylist);
            this.Controls.Add(this.dataGridViewPlaylistSongs);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.playlistName);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlaylistSongs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewPlaylistSongs;
        private System.Windows.Forms.Button createPlaylist;
        private System.Windows.Forms.Label playlistName;
        private System.Windows.Forms.TextBox textBox1;
    }
}