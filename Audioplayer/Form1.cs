﻿using System;
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
            isPlaying = false;
            QueueListbox.Visible = false;
            musicController = new MusicController();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        bool isPlaying;
        bool FirstPly = true;
        private void PlayBtn_Click(object sender, EventArgs e)
        {
            if (FirstPly)
            {
                musicController.PlaySong();
                PlayBtn.Text = "pause";
                FirstPly = false;
                isPlaying = !isPlaying;
                return;
            }
            musicController.ShowQueue(QueueListbox);
            musicController.UpdateQueue(false, QueueListbox);
            if (isPlaying)
            {
                PlayBtn.Text = "play";

                musicController.PauseSong();
                isPlaying = !isPlaying;
                return;
            }
            if (!FirstPly)
            {
                musicController.UnPause();
                PlayBtn.Text = "pause";

                isPlaying = !isPlaying;
                return;
            }

           

            extentions.DebugOutput(isPlaying.ToString());
        }

        private void NextSongBtn_Click(object sender, EventArgs e)
        {
            FirstPly = true;
            isPlaying = true;
            musicController.NextSong();

        }

        private void PrevSongBtn_Click(object sender, EventArgs e)
        {
            FirstPly = true;
            isPlaying = true;
            musicController.PreviousSong();


        }

        private void NextSongBtn_Click_1(object sender, EventArgs e)
        {
            musicController.NextSong();
        }
    }
}