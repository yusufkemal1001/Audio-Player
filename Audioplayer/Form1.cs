using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Audioplayer.Music_Controllers;
using System.Data.SqlClient;

namespace Audioplayer
{
    public partial class Form1 : Form
    {
        //Queue queue;
        Music_Controllers.MusicController musicController;
        //public string Filepath = @"C:\Users\jaime\source\repos\Audio-Player\Audioplayer\TempMusic";
        public string Filepath = @"C:\Users\yusuf\OneDrive\Desktop\Audio-Player\Audioplayer\TempMusic";
        SqlCaller SqlCaller = new SqlCaller();
        
        public Form1()
        {
            InitializeComponent();
            isPlaying = false;
            QueueListbox.Visible = false;

            musicController = new MusicController(mediaPlayer);
            
          
            musicController = new MusicController(mediaPlayer);
            

            LoadAllSongs();
            QueueListbox.DataSource = musicController.queueListbox;


        }
        void LoadAllSongs()
        {
            AllsongListbox.Items.Clear();
            List<string> songs = new List<string>();
            songs = SqlCaller.GetAllSongs();

            foreach (string item in songs)
            {
                AllsongListbox.Items.Add(item);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        bool isPlaying;
        bool FirstPly = true;
        private void PlayBtn_Click(object sender, EventArgs e)
        {
            if (FirstPly)
            {
                musicController.PlaySong();
              //  PlayBtn.BackgroundImage = Image.FromFile(@"C:\Users\yusuf\OneDrive\Desktop\Audio-Player\Audioplayer\Resources\pause.png");
                FirstPly = false;
                isPlaying = !isPlaying;
                return;
            }
            musicController.ShowQueue(QueueListbox);
            if (isPlaying)
            {
                PlayBtn.Text = "play";
               // PlayBtn.BackgroundImage = Image.FromFile(@"C:\Users\yusuf\OneDrive\Desktop\Audio-Player\Audioplayer\Resources\play-buttton.png");

               // musicController.PauseSong();
                isPlaying = !isPlaying;
                return;
            }
            if (!FirstPly)
            {
               // musicController.UnPause();
                
            //    PlayBtn.BackgroundImage = Image.FromFile(@"C:\Users\yusuf\OneDrive\Desktop\Audio-Player\Audioplayer\Resources\pause.png");

                isPlaying = !isPlaying;
                return;
            }

           

            extentions.DebugOutput(isPlaying.ToString());
        }

        private void NextSongBtn_Click(object sender, EventArgs e)
        {
            FirstPly = true;
            isPlaying = true;
          //  musicController.NextSong();

        }

        private void PrevSongBtn_Click(object sender, EventArgs e)
        {
            FirstPly = true;
            isPlaying = true;
         //   musicController.PreviousSong();


        }

        private void NextSongBtn_Click_1(object sender, EventArgs e)
        {
          //  musicController.NextSong();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (queueRadio.Checked == true)
            {
                QueueListbox.Show();
                AllsongListbox.Hide();
            }
            else
            {
                QueueListbox.Hide();
                AllsongListbox.Hide();
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (allSongsRadio.Checked == true)
            {
                QueueListbox.Hide();
                AllsongListbox.Show();
            }
            else
            {
                QueueListbox.Show();
                AllsongListbox.Hide();
                
            }
        }
       
        private void QueueListbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void Upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Audio files(mp3, wav, aac) | *.mp3;*.wav;*.aac | Alle Bestanden | *.*"; // file types, that will be allowed to upload 
            dialog.Multiselect = true; // allow/deny user to upload more than one file at a time
            if (dialog.ShowDialog() == DialogResult.OK) // if user clicked OK
            {
                var path = dialog.FileName; // get name of file
                using (StreamReader reader = new StreamReader(new FileStream(path, FileMode.Open), new UTF8Encoding())) // do anything you want, e.g. read it
                {

                    System.Diagnostics.Debug.WriteLine(dialog.FileNames.Length);
                    //SqlConnection con = new SqlConnection("Data Source=OBEJAH-LAPTOP\\SQLEXPRESS;Initial Catalog=AudioFiles;Integrated Security=True");
                    SqlCaller.UploadFiles(dialog);

                    LoadAllSongs();
                }
                    
                
                }
            }
        
        private void axWindowsMediaPlayer1_Enter_1(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mediaPlayer.URL = @"C:\Users\Yusuf Kemal Ozturk\Downloads\sorgu.mp3";
        }

        private void AllsongListbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void openPlaylist_Click(object sender, EventArgs e)
        {
        
            Form2 fm = new Form2(SqlCaller);
            fm.ShowDialog();

            



        }

        private void addToQueueBtn_Click(object sender, EventArgs e)
        {
            if(AllsongListbox.SelectedItems.Count <= 0)
            {
                return;
            }
            List<string> SelectedItemsAll = new List<string>();
            for (int i = 0; i < AllsongListbox.CheckedItems.Count; i++)
            {
                SelectedItemsAll.Add(AllsongListbox.CheckedItems[i].ToString());

            }
            extentions.DebugOutput(AllsongListbox.Items.Count.ToString());
            if (!musicController.Isplaying)
            {
                musicController.MakeQueue(SelectedItemsAll);
                return;
            }
            //mediaPlayer.URL=
            musicController.UpdateQueue(SelectedItemsAll);
            QueueListbox.Refresh();
        }

        private void loadFiles()
        {

        }
    }
}