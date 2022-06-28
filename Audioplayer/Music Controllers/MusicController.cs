
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
        public bool Isplaying = false;
        //string currentSong;
        // Mp3Player currentPlayer;
        //public IList<string> queueListbox = new List<string>();
        AxWMPLib.AxWindowsMediaPlayer mediaPlayer;
        public MusicController(AxWMPLib.AxWindowsMediaPlayer _mediaPlayer)
        {
            mediaPlayer = _mediaPlayer;
        }
        public void PlaySong()
        {
            LoadSong(queue.QueueList[0]);
        }
        private void LoadSong(string fileName)
        {
            if (queue == null)
            {
            }
            string fileType = fileName.Substring(fileName.Length - 4);
            if (fileType != ".mp3" && fileType != ".aac" && fileType != ".wav")
            {
                
            }
  
            //currentSong = fileName;
            
        }

      /*  public void NextSong()
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
        }*/
        public void MakeQueue()
        {
            MakeAxPlayslist();

            queue = new Queue();
            
         
            foreach (var item in queue.QueueList)
            {
                extentions.DebugOutput(item);
            }
            Isplaying = true;
        }
        public void ShuffleQueue()
        {
            queue.QueueList.Shuffle();
            UpdateQueue(queue.QueueList, true);
        }
        public void UpdateQueue(List<string> listBox, bool _reset = false )
        {
            if (_reset)
            {
                //queueListbox.Clear();
                mediaPlayer.currentPlaylist.clear();
            }
            foreach (var item in listBox)
            {
                queue.AddToQueue(item);
                //queueListbox.Add(item);
                mediaPlayer.currentPlaylist.appendItem(mediaPlayer.newMedia(item));
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
        void MakeAxPlayslist()
        {
            mediaPlayer.currentPlaylist = mediaPlayer.newPlaylist("QueueList", "");
        }
        public string[] GetQueue()
        {
            return queue.QueueList.ToArray();
        }
    }
}
