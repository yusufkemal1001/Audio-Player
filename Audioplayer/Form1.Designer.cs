
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
            this.SuspendLayout();
            // 
            // PlayBtn
            // 
            this.PlayBtn.Location = new System.Drawing.Point(728, 744);
            this.PlayBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.PlayBtn.Name = "PlayBtn";
            this.PlayBtn.Size = new System.Drawing.Size(150, 44);
            this.PlayBtn.TabIndex = 0;
            this.PlayBtn.Text = "Play1";
            this.PlayBtn.UseVisualStyleBackColor = true;
            this.PlayBtn.Click += new System.EventHandler(this.PlayBtn_Click);
            // 
            // NextSongBtn
            // 
            this.NextSongBtn.Location = new System.Drawing.Point(1004, 744);
            this.NextSongBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.NextSongBtn.Name = "NextSongBtn";
            this.NextSongBtn.Size = new System.Drawing.Size(150, 44);
            this.NextSongBtn.TabIndex = 1;
            this.NextSongBtn.Text = "Next";
            this.NextSongBtn.UseVisualStyleBackColor = true;
            this.NextSongBtn.Click += new System.EventHandler(this.NextSongBtn_Click_1);
            // 
            // PrevSongBtn
            // 
            this.PrevSongBtn.Location = new System.Drawing.Point(512, 744);
            this.PrevSongBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.PrevSongBtn.Name = "PrevSongBtn";
            this.PrevSongBtn.Size = new System.Drawing.Size(150, 44);
            this.PrevSongBtn.TabIndex = 2;
            this.PrevSongBtn.Text = "Prev";
            this.PrevSongBtn.UseVisualStyleBackColor = true;
            this.PrevSongBtn.Click += new System.EventHandler(this.PrevSongBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.PrevSongBtn);
            this.Controls.Add(this.NextSongBtn);
            this.Controls.Add(this.PlayBtn);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PlayBtn;
        private System.Windows.Forms.Button NextSongBtn;
        private System.Windows.Forms.Button PrevSongBtn;
    }
}

