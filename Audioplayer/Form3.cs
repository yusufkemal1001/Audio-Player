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
        public Form3()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            gridbind();
            
        }
        private void gridbind()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-VQ0G86A\\SQLEXPRESS;Initial Catalog=audioPlayer;Integrated Security=True");

            using (con)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from XD", con);
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridViewPlaylistSongs.DataSource = dt;
                dataGridViewPlaylistSongs.AllowUserToAddRows = false;
                DataGridViewCheckBoxColumn checkboxcol = new DataGridViewCheckBoxColumn();
                checkboxcol.Width = 40;
                checkboxcol.Name = "check1";
                checkboxcol.HeaderText = "";
                dataGridViewPlaylistSongs.Columns.Insert(0, checkboxcol);
                //con.Close();
            }
        }

        private void createPlaylist_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in dataGridViewPlaylistSongs.Rows)
            {
                bool select1 = Convert.ToBoolean(row.Cells["check1"].Value);
                if (select1)
                {
                    SqlCommand sql = new SqlCommand("Insert into Playlist ");
                }
            }
        }
    }
}
