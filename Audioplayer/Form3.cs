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

        
        SqlCaller SqlCaller = new SqlCaller();
        public Form3(SqlCaller caller)
        {
            InitializeComponent();
            SqlCaller.GetAllSongs();
            //textBox1.Text=playli
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("sup");    
        }

        private void updateName_Click(object sender, EventArgs e)
        {
            string updateName;
            updateName = textBox1.Text;
        }
    }
}
