using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Audioplayer.Music_Controllers;

namespace Audioplayer
{
    public partial class Form1 : Form
    {
        Music_Controllers.MusicController musicController;
        public string Filepath = @"C:\Users\jaime\source\repos\Audio-Player\Audioplayer\TempMusic";
        public Form1()
        {
            InitializeComponent();
            musicController = new MusicController();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PlayBtn_Click(object sender, EventArgs e)
        {
            musicController.Play(GetFileName());
        }

        private string GetFileName()
        {
            var files = Directory.GetFiles(Filepath);
            return files[0];
        }
    }
}
