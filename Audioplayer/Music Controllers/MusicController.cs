
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMPLib;
using System.Windows.Forms;
namespace Audioplayer.Music_Controllers
{
    public class MusicController
    {
        Queue queue;
        WindowsMediaPlayer mediaPlayer = new WindowsMediaPlayer();
        string currentSong;
        Mp3Player currentPlayer;
        ListBox queueList;
        
        public void SendComponents(ListBox _queueList, CheckedListBox _allsongList)
        {
            queueList = _queueList;
        }
        public void PlaySong()
        {
            MakeQueue();
            Play(queue.QueueList[0]);
        }
        private void Play(string fileName)
        {
            if (queue == null)
            {
                MakeQueue();
            }
            string fileType = fileName.Substring(fileName.Length - 4);
            if (fileType != ".mp3" && fileType != ".aac" && fileType != ".wav")
            {

            }
            currentPlayer.PlayAudio(fileName, mediaPlayer);
            currentSong = fileName;
        }

        public void NextSong()
        {
            int currentInt = queue.QueueList.IndexOf(currentSong);
            int nextint = currentInt + 1;
            extentions.DebugOutput(currentInt.ToString());
            extentions.DebugOutput(nextint.ToString());
            if (nextint > queue.QueueList.Count - 1)
            {
                nextint = 0;
            }
            string newSong = queue.QueueList[nextint];


            Play(newSong);
        }
        public void PreviousSong()
        {
            int currentInt = queue.QueueList.IndexOf(currentSong);
            int nextint = currentInt - 1;
            extentions.DebugOutput(currentInt.ToString());
            extentions.DebugOutput(nextint.ToString());
            if (nextint < 0)
            {
                nextint = queue.QueueList.Count - 1;
            }
            string newSong = queue.QueueList[nextint];
            Play(newSong);
        }

        public void PauseSong()
        {
            string fileType = currentSong.Substring(currentSong.Length - 4);
            if (fileType != ".mp3" && fileType != ".aac" && fileType != ".wav")
            {
                return;
            }
            currentPlayer.PauseAudio(mediaPlayer);
        }
        public void UnPause() {
            currentPlayer.UnPause(mediaPlayer);
        }
        public void MakeQueue()
        {
            Mp3Player Player = new Mp3Player();
            currentPlayer = Player;

            queue = new Queue();

          //  queue.AddToQueue(@"C:\Audio-Player\Audioplayer\TempMusic\Auto tune baby crying meme.aac");
            //queue.AddToQueue(@"C:\Audio-Player\Audioplayer\TempMusic\Goofy ahh sounds.wav");
            //queue.AddToQueue(@"C:\Audio-Player\Audioplayer\TempMusic\TYLER1 FULL GATLIN GUN-[AudioTrimmer.com].mp3");

            queue.AddToQueue(@"C:\Users\jaime\source\repos\Audio-Player\Audioplayer\TempMusic\Auto tune baby crying meme.aac");
            queue.AddToQueue(@"C:\Users\jaime\source\repos\Audio-Player\Audioplayer\TempMusic\Goofy ahh sounds.wav");
            queue.AddToQueue(@"C:\Users\jaime\source\repos\Audio-Player\Audioplayer\TempMusic\TYLER1 FULL GATLIN GUN-[AudioTrimmer.com].mp3");
            // queue.Shuffle();
            foreach (var item in queue.QueueList)
            {
                extentions.DebugOutput(item);
            }
        }
        public void ShuffleQueue()
        {
            queue.QueueList.Shuffle();
        }
        public void UpdateQueue(bool _reset, ListBox listBox)
        {
            if (_reset)
            {
                queueList.ResetText();
            }
            foreach (var item in queue.QueueList)
            {
                listBox.Items.Add(item);
            }
            //return queue.QueueList;
        }

        public void ShowQueue(ListBox listBox)
        {
            listBox.Visible = !listBox.Visible;
        }
        private void SwitchBool()
        {
           
        }
    }
}
