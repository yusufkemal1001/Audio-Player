using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMPLib;

namespace Audioplayer.Music_Controllers
{
    public class MusicController
    {
        WindowsMediaPlayer mediaPlayer = new WindowsMediaPlayer();

        public void Play(string fileName)
        {
            string fileType = fileName.Substring(fileName.Length - 4);
            if (fileType != ".mp3" && fileType != ".aac" && fileType != ".wav")
            {
                
            }
            Mp3Player Player = new Mp3Player();
            Player.PlayAudio(fileName, mediaPlayer);
        }
    }
}