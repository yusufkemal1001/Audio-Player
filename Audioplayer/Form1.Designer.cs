
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
            this.PlayBtn = new System.Windows.Forms.Button();
            this.NextSongBtn = new System.Windows.Forms.Button();
            this.PrevSongBtn = new System.Windows.Forms.Button();
            this.AllsongListbox = new System.Windows.Forms.CheckedListBox();
            this.QueueListbox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // PlayBtn
            // 
            this.PlayBtn.Location = new System.Drawing.Point(384, 415);
            this.PlayBtn.Name = "PlayBtn";
            this.PlayBtn.Size = new System.Drawing.Size(75, 23);
            this.PlayBtn.TabIndex = 0;
            this.PlayBtn.Text = "Play1";
            this.PlayBtn.UseVisualStyleBackColor = true;
            this.PlayBtn.Click += new System.EventHandler(this.PlayBtn_Click);
            // 
            // NextSongBtn
            // 
            this.NextSongBtn.Location = new System.Drawing.Point(549, 415);
            this.NextSongBtn.Name = "NextSongBtn";
            this.NextSongBtn.Size = new System.Drawing.Size(75, 23);
            this.NextSongBtn.TabIndex = 1;
            this.NextSongBtn.Text = "Next";
            this.NextSongBtn.UseVisualStyleBackColor = true;
            this.NextSongBtn.Click += new System.EventHandler(this.NextSongBtn_Click_1);
            // 
            // PrevSongBtn
            // 
            this.PrevSongBtn.Location = new System.Drawing.Point(222, 415);
            this.PrevSongBtn.Name = "PrevSongBtn";
            this.PrevSongBtn.Size = new System.Drawing.Size(75, 23);
            this.PrevSongBtn.TabIndex = 2;
            this.PrevSongBtn.Text = "Prev";
            this.PrevSongBtn.UseVisualStyleBackColor = true;
            this.PrevSongBtn.Click += new System.EventHandler(this.PrevSongBtn_Click);
            // 
            // AllsongListbox
            // 
            this.AllsongListbox.FormattingEnabled = true;
            this.AllsongListbox.Location = new System.Drawing.Point(638, 12);
            this.AllsongListbox.Name = "AllsongListbox";
            this.AllsongListbox.Size = new System.Drawing.Size(150, 394);
            this.AllsongListbox.TabIndex = 3;
            this.AllsongListbox.Visible = false;
            // 
            // QueueListbox
            // 
            this.QueueListbox.FormattingEnabled = true;
            this.QueueListbox.Items.AddRange(new object[] {
            "hoi"});
            this.QueueListbox.Location = new System.Drawing.Point(474, 15);
            this.QueueListbox.Name = "QueueListbox";
            this.QueueListbox.Size = new System.Drawing.Size(150, 394);
            this.QueueListbox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.QueueListbox);
            this.Controls.Add(this.AllsongListbox);
            this.Controls.Add(this.PrevSongBtn);
            this.Controls.Add(this.NextSongBtn);
            this.Controls.Add(this.PlayBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PlayBtn;
        private System.Windows.Forms.Button NextSongBtn;
        private System.Windows.Forms.Button PrevSongBtn;
        private System.Windows.Forms.CheckedListBox AllsongListbox;
        private System.Windows.Forms.ListBox QueueListbox;
    }
}

