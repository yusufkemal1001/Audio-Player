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
        public Form2(SqlCaller caller)
        {
            InitializeComponent();
            SqlCaller = caller;
            LoadPlaylist();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LoadPlaylist();
            CreateRows();
            
        }
        private void LoadPlaylist()
        {
            DataTable dt = SqlCaller.GetAllPlaylist();
                
                dataGridViewPlaylists.DataSource = dt;
            dataGridViewPlaylists.Columns[0].Visible = false;
            dataGridViewPlaylists.Columns[1].Width = dataGridViewPlaylists.Width;
            dataGridViewPlaylists.Refresh();

        }

        void CreateRows() 
        {
            /*dataGridViewPlaylists.AllowUserToAddRows = false;
            DataGridViewCheckBoxColumn checkboxcol = new DataGridViewCheckBoxColumn();
            checkboxcol.Width = 40;
            checkboxcol.Name = "check1";
            checkboxcol.HeaderText = "";
            dataGridViewPlaylists.Columns.Insert(0, checkboxcol);*/

            
        }

        

        private void addPlaylist_Click_1(object sender, EventArgs e)
        {
            string input;
            input = textBox1.Text;
            SqlCaller.addPlaylist(input);
                dataGridViewPlaylists.Refresh();
            //con.Close();
            SqlCaller.GetAllPlaylist();
            playlistGridUpdate();
            textBox1.Clear();
        }
        void playlistGridUpdate()
        {
            
            LoadPlaylist();
            
            
        }

        private void dataGridViewPlaylists_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridViewPlaylists_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           PlayslistInt = (int)dataGridViewPlaylists[0, e.RowIndex].Value;
            Form3 fm = new Form3(SqlCaller);
            fm.textBox1.Text = (string)dataGridViewPlaylists[1, e.RowIndex].Value;
            fm.ShowDialog();
        }
   
    }
}
