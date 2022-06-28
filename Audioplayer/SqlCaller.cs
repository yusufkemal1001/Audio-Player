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
        private SqlConnection con;

        public SqlCaller()
        {
            con = new SqlConnection("Server=localhost\\SQLEXPRESS01;Database=audioPlayer;Trusted_Connection=True;");
        }

        public void CreateConnection()
        {
            //con = new SqlConnection("Server=OBEJAH-LAPTOP\\SQLEXPRESS;Database=audioPlayer;Trusted_Connection=True;");
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
            using (con)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into Playlists values('" + input + "')", con);
                
                //con.Close();
            }
        }
        public List<string> GetAllSongs()
        {
            List<string> songs = new List<string>();
            string querry = "select * from XD";
            con.Open();



            SqlCommand cmd = new SqlCommand(querry, con);
            cmd.CommandType = CommandType.Text;
                


                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            songs.Add(reader.GetString(1));
                        }
                    }

            con.Close();
            return songs;

        }
    public void UploadFiles(FileDialog dialog)
        {
            con.Open();

            for (int i = 0; i < dialog.FileNames.Length; i++)
            {
                System.Diagnostics.Debug.WriteLine(dialog.FileNames[i]);
                SqlCommand cmd = new SqlCommand("insert into XD (Path) values (@Path)", con);
                cmd.Parameters.AddWithValue("@Path", dialog.FileNames[i] + Environment.NewLine);
                cmd.ExecuteNonQuery();

            }
            con.Close();
        }
    }
}
