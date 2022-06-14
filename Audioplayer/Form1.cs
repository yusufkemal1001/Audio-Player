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
        Queue queue;
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
            musicController.PlaySong();
        }

        private void NextSongBtn_Click(object sender, EventArgs e)
        {
            musicController.NextSong();

        }

        private void PrevSongBtn_Click(object sender, EventArgs e)
        {
            musicController.PreviousSong();
        }

        private void NextSongBtn_Click_1(object sender, EventArgs e)
        {
            musicController.NextSong();
        }
    }
}