﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Audioplayer.Music_Controllers
{
    class Queue
    {
        public List<string> QueueList = new List<string>();

        public void AddToQueue(string _Url)
        {
           bool isUrl = _Url.Contains(".");
            if (!isUrl)
            {
                //error not valid url
                return;
            }
            QueueList.Add(_Url);
        }
       
    }
}
