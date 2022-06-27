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
        public Form2()
        {
            InitializeComponent();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            gridbind();
            
        }
        private void gridbind()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-VQ0G86A\\SQLEXPRESS;Initial Catalog=audioPlayer;Integrated Security=True");

            using (con)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Playlist", con);
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridViewPlaylists.DataSource = dt;
                dataGridViewPlaylists.AllowUserToAddRows = false;
                DataGridViewCheckBoxColumn checkboxcol = new DataGridViewCheckBoxColumn();
                checkboxcol.Width = 40;
                checkboxcol.Name = "check1";
                checkboxcol.HeaderText = "";
                dataGridViewPlaylists.Columns.Insert(0, checkboxcol);
                //con.Close();
            }
        }

        private void addPlaylist_Click(object sender, EventArgs e)
        {
            Form3 fm = new Form3();
            fm.ShowDialog();
        }

        private void addPlaylist_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-VQ0G86A\\SQLEXPRESS;Initial Catalog=audioPlayer;Integrated Security=True");
            using (con)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into Playlist values('"+textBox1.Text+"')", con);
                SqlDataReader reader = cmd.ExecuteReader();
                dataGridViewPlaylists.Refresh();
                //con.Close();
            }
            textBox1.Clear();
        }

    }
}
