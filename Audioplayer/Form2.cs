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
    public partial class Form2 : Form
    {
        SqlCaller SqlCaller;
        public int PlayslistInt;
        Form1 fromie;
        public Form2(SqlCaller caller, Form1 form)
        {
            InitializeComponent();
            SqlCaller = caller;
            fromie = form;
            LoadPlaylist();
        }
        
        public void LoadPlaylist()
        {
            DataTable dt = SqlCaller.GetAllPlaylist();
            dataGridViewPlaylists.DataSource = dt;
            dataGridViewPlaylists.Columns[0].Visible = false;
            dataGridViewPlaylists.Columns[1].Width = dataGridViewPlaylists.Width;
            dataGridViewPlaylists.Refresh();
        }

        private void addPlaylist_Click_1(object sender, EventArgs e)
        {
            string input;
            input = textBox1.Text;
            input.Trim();
            SqlCaller.addPlaylist(input);
            dataGridViewPlaylists.Refresh();
            SqlCaller.GetAllPlaylist();
            playlistGridUpdate();
            textBox1.Clear();
            fromie.GetPlaylists();
        }
        void playlistGridUpdate()
        {
            LoadPlaylist();
        }

        private void dataGridViewPlaylists_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            PlayslistInt = (int)dataGridViewPlaylists[0, e.RowIndex].Value;
            Form3 fm = new Form3(SqlCaller, PlayslistInt, this);
            fm.textBox1.Text = (string)dataGridViewPlaylists[1, e.RowIndex].Value;
            fm.ShowDialog();
        }

        private void dataGridViewPlaylists_CellContentDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            PlayslistInt = (int)dataGridViewPlaylists[0, e.RowIndex].Value;
            Form3 fm = new Form3(SqlCaller, PlayslistInt, this);
            fm.textBox1.Text = (string)dataGridViewPlaylists[1, e.RowIndex].Value;
            fm.ShowDialog();
        }
    }
}
