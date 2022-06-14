
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
            this.components = new System.ComponentModel.Container();
            this.PlayBtn = new System.Windows.Forms.Button();
<<<<<<< Updated upstream
            this.audioFilesDataSet = new Audioplayer.AudioFilesDataSet();
            this.audioFilesDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.audioFilesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.audioFilesDataSetBindingSource)).BeginInit();
=======
            this.NextSongBtn = new System.Windows.Forms.Button();
>>>>>>> Stashed changes
            this.SuspendLayout();
            // 
            // PlayBtn
            // 
            this.PlayBtn.Location = new System.Drawing.Point(364, 387);
            this.PlayBtn.Name = "PlayBtn";
            this.PlayBtn.Size = new System.Drawing.Size(75, 23);
            this.PlayBtn.TabIndex = 0;
            this.PlayBtn.Text = "Play1";
            this.PlayBtn.UseVisualStyleBackColor = true;
            this.PlayBtn.Click += new System.EventHandler(this.PlayBtn_Click);
            // 
<<<<<<< Updated upstream
            // audioFilesDataSet
            // 
            this.audioFilesDataSet.DataSetName = "AudioFilesDataSet";
            this.audioFilesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // audioFilesDataSetBindingSource
            // 
            this.audioFilesDataSetBindingSource.DataSource = this.audioFilesDataSet;
            this.audioFilesDataSetBindingSource.Position = 0;
=======
            // NextSongBtn
            // 
            this.NextSongBtn.Location = new System.Drawing.Point(471, 387);
            this.NextSongBtn.Name = "NextSongBtn";
            this.NextSongBtn.Size = new System.Drawing.Size(75, 23);
            this.NextSongBtn.TabIndex = 1;
            this.NextSongBtn.Text = "nextSong";
            this.NextSongBtn.UseVisualStyleBackColor = true;
            this.NextSongBtn.Click += new System.EventHandler(this.NextSongBtn_Click);
>>>>>>> Stashed changes
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NextSongBtn);
            this.Controls.Add(this.PlayBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.audioFilesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.audioFilesDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PlayBtn;
<<<<<<< Updated upstream
        private System.Windows.Forms.BindingSource audioFilesDataSetBindingSource;
        private AudioFilesDataSet audioFilesDataSet;
=======
        private System.Windows.Forms.Button NextSongBtn;
>>>>>>> Stashed changes
    }
}

