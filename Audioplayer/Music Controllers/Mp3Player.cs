﻿using System;
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
     
        
        public void PlayMp3(string _fileName, System.Media.SoundPlayer _soundPlayer)
        {
            soundPlayer = _soundPlayer;
            fileName = _fileName;
            soundPlayer.SoundLocation = fileName;
            soundPlayer.
            soundPlayer.Play();
        }
    }
}
