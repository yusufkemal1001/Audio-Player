using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace Audioplayer.Music_Controllers
{
    public class Mp3Player
    {
        SoundPlayer soundPlayer;
        string fileName;
        public void Mp3Controller(string _filename, System.Media.SoundPlayer _soundPlayer)
        {
            soundPlayer = _soundPlayer;
        }

        public void PlayMp3(string _fileName)
        {
            fileName = _fileName;
            soundPlayer.SoundLocation = fileName;
            soundPlayer.Play();
        }
    }
}
