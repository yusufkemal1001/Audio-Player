using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Audioplayer
{
    public partial class Form3 : Form
    {

        
        SqlCaller SqlCaller;
        int PlayListId;
        List<string> Urls = new List<string>();
        List<string> Allsongs = new List<string>();
        List<int> plSongIDs = new List<int>();
        Form2 form;
        public Form3(SqlCaller caller, int _ID, Form2 _form)
        {
            InitializeComponent();
            SqlCaller = caller;
            PlayListId = _ID;
            Urls = SqlCaller.GetAllSongs();
            LoadAllsongs();
            form = _form;
            loadAllPlsongs();
            //textBox1.Text=playli
        }
        void getSongName(List<string> SongList)
        {

            foreach (string item in SongList)
            {
                string lastPart = item.Split('\\').Last();
                AllsongListbox.Items.Add(lastPart);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<string> addSongs = new List<string>();
            for (int i = 0; i < AllsongListbox.Items.Count; i++)
            {
                if (AllsongListbox.GetItemCheckState(i) == CheckState.Checked)
                {
                 
                  addSongs.Add(Urls[i].ToString());
                }

            }
            SqlCaller.AddSongsToPlayList(PlayListId, addSongs);
            loadAllPlsongs();
            
        }
        void LoadAllsongs()
        {
            getSongName(Urls);
        }

        private void updateName_Click(object sender, EventArgs e)
        {
            SqlCaller.UpdatePlaylistName(textBox1.Text, PlayListId);
            form.LoadPlaylist();
        }
        private void loadAllPlsongs()
        {
            PlaylistSongsListbox.Items.Clear();
            plSongIDs = SqlCaller.GetAllPlaylistSongsId(PlayListId);
            Allsongs = SqlCaller.GetSongNameById(plSongIDs);
            foreach (string item in Allsongs)
            {
                string lastPart = item.Split('\\').Last();
                PlaylistSongsListbox.Items.Add(lastPart);
            }
        }

        private void delSongsPlaylist_Click(object sender, EventArgs e)
        {
            List<int> delSongs = new List<int>();
            for (int i = 0; i < PlaylistSongsListbox.CheckedItems.Count; i++)
            {
                delSongs.Add(plSongIDs[i]);

            }
            SqlCaller.DeleteSongFromPlatlist(delSongs);
            loadAllPlsongs();
        }

        private void deletePlaylistBtn_Click(object sender, EventArgs e)
        {
            SqlCaller.DeletePlaylist(PlayListId);
            this.Close();
        }
    }
}
