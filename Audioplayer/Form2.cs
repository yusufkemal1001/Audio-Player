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
        public Form2()
        {
            InitializeComponent();
            SqlCaller = new SqlCaller();
            LoadPlaylist();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
            
        }
        private void LoadPlaylist()
        {
            DataTable dt = SqlCaller.GetAllPlaylist();
                
                dataGridViewPlaylists.DataSource = dt;
                dataGridViewPlaylists.AllowUserToAddRows = false;
                DataGridViewCheckBoxColumn checkboxcol = new DataGridViewCheckBoxColumn();
                checkboxcol.Width = 40;
                checkboxcol.Name = "check1";
                checkboxcol.HeaderText = "";
                dataGridViewPlaylists.Columns.Insert(0, checkboxcol);
               
            
        }

        private void addPlaylist_Click(object sender, EventArgs e)
        {
            Form3 fm = new Form3();
            fm.ShowDialog();
        }

        private void addPlaylist_Click_1(object sender, EventArgs e)
        {
            SqlCaller.addPlaylist(textBox1.Text);
                dataGridViewPlaylists.Refresh();
                //con.Close();
            
            textBox1.Clear();
        }

    }
}
