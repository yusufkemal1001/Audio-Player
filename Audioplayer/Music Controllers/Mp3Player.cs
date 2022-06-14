using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using WMPLib;

namespace Audioplayer.Music_Controllers
{
    public class Mp3Player
    {
        WindowsMediaPlayer soundPlayer;
        string fileName;
     
        
        public void PlayMp3(string _fileName, WindowsMediaPlayer _soundPlayer)
        {
            soundPlayer = _soundPlayer;
            fileName = _fileName;

            soundPlayer.URL = fileName;
            soundPlayer.controls.play();
           
        }
    }
}
