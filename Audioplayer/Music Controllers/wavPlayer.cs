using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace Audioplayer.Music_Controllers
{
    public class wavePlayer
    {
        SoundPlayer soundPlayer;
        string fileName;
     

        public void PlayWav(string _fileName, System.Media.SoundPlayer _soundPlayer)
        {
            soundPlayer = _soundPlayer;
            fileName = _fileName;
            soundPlayer.SoundLocation = fileName;
            soundPlayer.Play();
        }
    }
}
