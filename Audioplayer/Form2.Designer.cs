namespace Audioplayer
{
    partial class Form2
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
            this.addPlaylist = new System.Windows.Forms.Button();
            this.dataGridViewPlaylists = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.deletePlaylistBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.addToQueueBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlaylists)).BeginInit();
            this.SuspendLayout();
            // 
            // addPlaylist
            // 
            this.addPlaylist.Location = new System.Drawing.Point(220, 33);
            this.addPlaylist.Name = "addPlaylist";
            this.addPlaylist.Size = new System.Drawing.Size(97, 23);
            this.addPlaylist.TabIndex = 0;
            this.addPlaylist.Text = "Add Playlist";
            this.addPlaylist.UseVisualStyleBackColor = true;
            this.addPlaylist.Click += new System.EventHandler(this.addPlaylist_Click_1);
            // 
            // dataGridViewPlaylists
            // 
            this.dataGridViewPlaylists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPlaylists.Location = new System.Drawing.Point(26, 169);
            this.dataGridViewPlaylists.Name = "dataGridViewPlaylists";
            this.dataGridViewPlaylists.Size = new System.Drawing.Size(292, 210);
            this.dataGridViewPlaylists.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(26, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(173, 20);
            this.textBox1.TabIndex = 2;
            // 
            // deletePlaylistBtn
            // 
            this.deletePlaylistBtn.Location = new System.Drawing.Point(242, 131);
            this.deletePlaylistBtn.Name = "deletePlaylistBtn";
            this.deletePlaylistBtn.Size = new System.Drawing.Size(75, 23);
            this.deletePlaylistBtn.TabIndex = 3;
            this.deletePlaylistBtn.Text = "Delete";
            this.deletePlaylistBtn.UseVisualStyleBackColor = true;
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(141, 131);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(75, 23);
            this.editBtn.TabIndex = 4;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = true;
            // 
            // addToQueueBtn
            // 
            this.addToQueueBtn.Location = new System.Drawing.Point(26, 131);
            this.addToQueueBtn.Name = "addToQueueBtn";
            this.addToQueueBtn.Size = new System.Drawing.Size(91, 23);
            this.addToQueueBtn.TabIndex = 5;
            this.addToQueueBtn.Text = "Add To Queue";
            this.addToQueueBtn.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 433);
            this.Controls.Add(this.addToQueueBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.deletePlaylistBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridViewPlaylists);
            this.Controls.Add(this.addPlaylist);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlaylists)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addPlaylist;
        private System.Windows.Forms.DataGridView dataGridViewPlaylists;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button deletePlaylistBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button addToQueueBtn;
    }
}