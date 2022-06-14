using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace Audioplayer.Music_Controllers
{
     public class MusicController
    {
        System.Media.SoundPlayer soundPlayer = new SoundPlayer();
        
        public void Play(string fileName)
        {
            string fileType = fileName.Substring(fileName.Length - 4);
            if (fileType == ".mp3")
            {
                
            }
        }

    }
}
