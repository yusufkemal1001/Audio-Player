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
        Music_Controllers.MusicController musicController;
        SqlCaller SqlCaller = new SqlCaller();


        public Form1()
        {
            InitializeComponent();
            musicController = new MusicController(mediaPlayer);

            musicController.SendUrlToList(SqlCaller.GetAllSongs());
            List<string> peepee = SqlCaller.GetAllSongs();

            LoadAllPlaylists();
            LoadAllSongs();
            musicController.MakeQueue();
        }
        void LoadAllSongs()
        {
            AllsongListbox.Items.Clear();
            getSongName(musicController.SongUrls);
            
        }
        void getSongName(List<string>SongList)
        {

            foreach (string item in SongList)
            {
                string lastPart = item.Split('\\').Last();
                AllsongListbox.Items.Add(lastPart);
            }
        }
        void LoadAllPlaylists()
        {
            PlaylistListbox.DataSource = null;
            PlaylistListbox.Refresh();
            PlaylistListbox.DataSource = SqlCaller.GetAllPlaylist();
            PlaylistListbox.DisplayMember = "Name";
            PlaylistListbox.Refresh();
        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (queueRadio.Checked == true)
            {
                PlaylistListbox.Show();
                AllsongListbox.Hide();
            }
            else
            {
                PlaylistListbox.Hide();
                AllsongListbox.Show();
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (allSongsRadio.Checked == true)
            {
                PlaylistListbox.Hide();
                AllsongListbox.Show();
            }
            else
            {
                PlaylistListbox.Show();
                AllsongListbox.Hide();
                
            }
        }


        private void Upload_Click(object sender, EventArgs e)
        {

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Audio files(mp3, wav, aac) | *.mp3;*.wav;*.aac | Alle Bestanden | *.*"; // file types, that will be allowed to upload 
            dialog.Multiselect = true; // allow/deny user to upload more than one file at a time
            if (dialog.ShowDialog() == DialogResult.OK) // if user clicked OK
            {
                var path = dialog.FileName; // get name of file
                string Path;
                Path = path;
                int songsCount=SqlCaller.GetNumberOfSongs(Path);
                if (songsCount == 1)
                {
                    MessageBox.Show("File already exists");
                    return;
                }

                using (StreamReader reader = new StreamReader(new FileStream(path, FileMode.Open), new UTF8Encoding())) // do anything you want, e.g. read it
                {
                   System.Diagnostics.Debug.WriteLine(dialog.FileNames.Length);
                   SqlCaller.UploadFiles(dialog);
                   musicController.SendUrlToList(SqlCaller.GetAllSongs());
                }
            }
            LoadAllSongs();
        }
        
        private void openPlaylist_Click(object sender, EventArgs e)
        {
            Form2 fm = new Form2(SqlCaller, this);
            fm.ShowDialog();
        }

        private void addToQueueBtn_Click(object sender, EventArgs e)
        {
            if(queueRadio.Checked == true)
            {
                var selectedI = PlaylistListbox.SelectedItem;
                string selected = PlaylistListbox.GetItemText(selectedI);

                musicController.UpdateQueue(SqlCaller.GetSongNameById(SqlCaller.GetAllPlaylistSongsId(SqlCaller.GetPlaylistIDByName(selected))));
                ListQueueUpdate();

            }
            if(AllsongListbox.SelectedItems.Count <= 0)
            {
                return;
            }
            List<string> SelectedItemsAll = new List<string>();
            for (int i = 0; i < AllsongListbox.Items.Count; i++)
            {
                if (AllsongListbox.GetItemCheckState(i) == CheckState.Checked)
                {
                    extentions.DebugOutput(i.ToString());
                    SelectedItemsAll.Add(AllsongListbox.Items[i].ToString());
                }
            }
            extentions.DebugOutput(AllsongListbox.Items.Count.ToString());
            musicController.UpdateQueue(SelectedItemsAll);
            ListQueueUpdate();
            Uncheck();
        }

        void ListQueueUpdate()
        {
            QueueListbox.Items.Clear();
            foreach (var item in musicController.GetQueue())
            {
                string lastPart = item.Split('\\').Last();
                QueueListbox.Items.Add(lastPart);
            }
            QueueListbox.Refresh();
        }
        
        void Uncheck()
        {
            LoadAllSongs();
        }

        public void GetPlaylists()
        {
            LoadAllPlaylists();
        }
    }
}