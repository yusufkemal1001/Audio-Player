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
    public class SqlCaller
    {
        SqlConnection con;
        public void CreateConnection()
        {
            con = new SqlConnection("Server=localhost\\SQLEXPRESS01;Database=audioPlayer;Trusted_Connection=True;");
        }
        public DataTable GetAllPlaylist()
        {
            
            con.Open();

            using (con)
            {
                SqlCommand cmd = new SqlCommand("select * from Playlist", con);
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                return dt;
                //con.Close();
            }
        }

      
        public void addPlaylist(string input)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-VQ0G86A\\SQLEXPRESS;Initial Catalog=audioPlayer;Integrated Security=True");
            using (con)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into Playlist values('" + input + "')", con);
                SqlDataReader reader = cmd.ExecuteReader();
                
                //con.Close();
            }
        }
        public List<string> GetAllSongs()
        {
            List<string> songs = new List<string>();



            return songs;

        }
    
    }
}
