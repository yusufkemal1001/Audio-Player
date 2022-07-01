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
            DataTable result = new DataTable();
            CreateConnection();
            con.Open();

            using (con)
            {
                SqlCommand cmd = new SqlCommand("select * from Playlists", con);
                SqlDataReader reader = cmd.ExecuteReader();
                
                result.Load(reader);
                con.Close();
            }
            return result;
        }


      
        public void addPlaylist(string input)
        {
            using (con)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into Playlists values('" + input + "')", con);
                SqlDataReader reader = cmd.ExecuteReader();

                con.Close();
            }
        }
       
        public List<string> GetAllSongs()
        {
            CreateConnection();
            con.Open();
            List<string> songs = new List<string>();
            string querry = "select * from XD";
            



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

        public List<int> GetAllPlaylistSongsId(int _ID)
        {
            List<int> songs = new List<int>();
            string querry = $"select * from PlaylistContent where playlistID ='{_ID}'";
            con.Open();



            SqlCommand cmd = new SqlCommand(querry, con);
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;



            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    var str = reader.GetInt32(2);
                    songs.Add(str);
                }
            }

            con.Close();
            return songs;

        }
       public List<string> GetSongNameById(List<int> _ID)
        {

            con.Open();
            List<string> url = new List<string>();
            foreach (var item in _ID)
            {
            SqlCommand cmd = new SqlCommand($"select Path from XD where songID = '{item}'");
            cmd.Connection = con;
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                    url.Add(reader.GetString(0));

                    }
                }


                   

            }
            con.Close();
            return url;
        }

        public void UploadFiles(FileDialog dialog)
        {
            CreateConnection();
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
        public void UpdatePlaylistName(string _name, int _ID)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand($"update Playlists set Playlist = '{_name}' where PlayListID = '{_ID}'", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void AddSongsToPlayList(int _playListID, List<string> _url)
        {
            con.Open();

            foreach (int item in GetSongIdsByName(_url))
            {
                SqlCommand cmd = new SqlCommand($"insert into PlaylistContent values('{_playListID}', '{item}')");
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
            }
            con.Close();
        }
        public List<int> GetSongIdsByName(List<string> _url)
        {
            List<int> songs = new List<int>();
            foreach (string item in _url)
            {
                
               
                SqlCommand cmd = new SqlCommand($"select songID from XD where Path Like '%{item}%'");
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var peepee = reader.GetInt32(0);
                        songs.Add(peepee);

                    }
                }

            }

            return songs;

        }
        public void DeleteSongFromPlatlist(List<int> _url)
        {
            con.Open();
            foreach (var item in _url)
            {
                SqlCommand cmd = new SqlCommand($"delete from PlaylistContent where songID = '{item}' ");
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
            }
            con.Close();

        }
        public void DeletePlaylist(int _PlaylistId)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand($"delete from PlaylistContent where playlistID = '{_PlaylistId}' ");
            cmd.Connection = con;
            cmd.ExecuteNonQuery();

            SqlCommand cmd2 = new SqlCommand($"delete from Playlists where playlistID = '{_PlaylistId}' ");
            cmd2.Connection = con;
            cmd2.ExecuteNonQuery();
            con.Close();
        }
        public int GetPlaylistIDByName(string _name)
        {
            
            CreateConnection();
            con.Open();
            int Id=0;
            SqlCommand cmd = new SqlCommand($"select playlistID from Playlists where Playlist='{_name}';");
            cmd.Connection = con;
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Id = dr.GetInt32(0);

                
                
            }
            con.Close();
            return Id;
            /*using (SqlDataReader reader = cmd.ExecuteReader())
            {
                
                    

                
            }*/




        }
    }
}
