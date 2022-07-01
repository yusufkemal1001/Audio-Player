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
            this.dataGridViewPlaylists.AllowUserToAddRows = false;
            this.dataGridViewPlaylists.AllowUserToDeleteRows = false;
            this.dataGridViewPlaylists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPlaylists.Location = new System.Drawing.Point(12, 103);
            this.dataGridViewPlaylists.MultiSelect = false;
            this.dataGridViewPlaylists.Name = "dataGridViewPlaylists";
            this.dataGridViewPlaylists.ReadOnly = true;
            this.dataGridViewPlaylists.RowHeadersVisible = false;
            this.dataGridViewPlaylists.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewPlaylists.Size = new System.Drawing.Size(305, 280);
            this.dataGridViewPlaylists.TabIndex = 1;
            this.dataGridViewPlaylists.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPlaylists_CellContentClick);
            this.dataGridViewPlaylists.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPlaylists_CellContentDoubleClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(26, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(173, 20);
            this.textBox1.TabIndex = 2;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 433);
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
    }
}