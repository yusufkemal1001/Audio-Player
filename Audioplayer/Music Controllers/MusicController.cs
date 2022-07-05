
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
        public List<string> SongUrls = new List<string>();
        public MusicController(AxWMPLib.AxWindowsMediaPlayer _mediaPlayer)
        {
            mediaPlayer = _mediaPlayer;
        }

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
            UpdateQueue(queue.QueueList ,true);
        }
        public void UpdateQueue(List<string> selected, bool _reset = false )
        {
            if (_reset)
            {
                mediaPlayer.currentPlaylist.clear();
            }
            for (int i = 0; i < selected.Count; i++)
            {
                string addsong = SongUrls.Where(newsong => newsong.Contains(selected[i])).FirstOrDefault();
                queue.AddToQueue(selected[i]);
                mediaPlayer.currentPlaylist.appendItem(mediaPlayer.newMedia(addsong));
            }
        }
        void MakeAxPlayslist()
        {
            mediaPlayer.currentPlaylist = mediaPlayer.newPlaylist("QueueList", "");
        }
        public string[] GetQueue()
        {
            return queue.QueueList.ToArray();
        }
        public void SendUrlToList(List<string> songs)
        {
           SongUrls = songs;
           extentions.DebugOutput(SongUrls.Count.ToString());
        }
    }
}
