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
            con = new SqlConnection("Data Source=OBEJAH-LAPTOP\\SQLEXPRESS;Initial Catalog=audioPlayer;Integrated Security=True");
        }

        public void CreateConnection()
        {
            //con = new SqlConnection("Server=OBEJAH-LAPTOP\\SQLEXPRESS;Database=audioPlayer;Trusted_Connection=True;");
            con = new SqlConnection("Data Source=OBEJAH-LAPTOP\\SQLEXPRESS;Initial Catalog=audioPlayer;Integrated Security=True");
        }
        public DataTable GetAllPlaylist()
        {
            DataTable result = new DataTable();
            DataRow dr;
            result.Columns.Add("ID", typeof(int));
            result.Columns.Add("Name", typeof(string));
            int i = 0;
            using (var db = new DbContextModel())
            {
                var query = from p in db.Playlists
                            select p;
                foreach(var item in query)
                {
                    dr = result.NewRow();
                    result.Rows.Add(dr);
                    result.Rows[i][0] = item.ID;
                    result.Rows[i][1] = item.Name;
                    i++;
                }
            }
/*                CreateConnection();
            con.Open();

            using (con)
            {
                SqlCommand cmd = new SqlCommand("select * from Playlists", con);
                SqlDataReader reader = cmd.ExecuteReader();
                
                result.Load(reader);
                con.Close();
            }*/
            return result;
        }


      
        public void addPlaylist(string input)
        {
            using (con)
            {
                using(var db = new DbContextModel())
                {
                    var PlaylistName = input;
                    var PList = new Playlists { Name = PlaylistName };
                    db.Playlists.Add(PList);
                    db.SaveChanges();
                }
                //con.Open();
                /*SqlCommand cmd = new SqlCommand("insert into Playlists values('" + input + "')", con);
                SqlDataReader reader = cmd.ExecuteReader();*/

                //con.Close();
            }
        }
       
        public List<string> GetAllSongs()
        {
            /*CreateConnection();
            con.Open();*/
            List<string> songs = new List<string>();
            using (var db = new DbContextModel())
            {
                var query = from p in db.Nummers
                            select p;
                foreach(var item in query)
                {
                    songs.Add(item.Path);
                }
            }

                /*string querry = "select * from XD";
            



            SqlCommand cmd = new SqlCommand(querry, con);
            cmd.CommandType = CommandType.Text;
                


                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            songs.Add(reader.GetString(1));
                        }
                    }

            con.Close();*/

            return songs;

        }

        public List<int> GetAllPlaylistSongsId(int _ID)
        {
            List<int> songs = new List<int>();
            using (var db = new DbContextModel())
            {
                var query = from p in db.PlaylistInhoud
                            select p;
                foreach (var item in query)
                {
                    songs.Add(item.Playlist_ID);
                }
            }
              /*  string querry = $"select * from PlaylistContent where playlistID ='{_ID}'";
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

            con.Close();*/
            return songs;

        }
       public List<string> GetSongNameById(List<int> _ID)
        {

           // con.Open();
            List<string> url = new List<string>();
            foreach (var item in _ID)
            {
                using (var db = new DbContextModel())
                {
                    var query = from p in db.Nummers
                                select p;
                    foreach (var items in query)
                    {
                        url.Add(items.Path);
                    }
                }

                /*SqlCommand cmd = new SqlCommand($"select Path from XD where songID = '{item}'");
                cmd.Connection = con;
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                        url.Add(reader.GetString(0));

                        }
                    }*/




            }
           // con.Close();
            return url;
        }

        public void UploadFiles(FileDialog dialog)
        {
            /*CreateConnection();
            con.Open();*/

            for (int i = 0; i < dialog.FileNames.Length; i++)
            {
                System.Diagnostics.Debug.WriteLine(dialog.FileNames[i]);
                using(var db = new DbContextModel())
                {
                    var path = new Nummers { Path = dialog.FileNames[i] };
                    db.Nummers.Add(path);
                    db.SaveChanges();
                }

                /*SqlCommand cmd = new SqlCommand("insert into XD (Path) values (@Path)", con);
                cmd.Parameters.AddWithValue("@Path", dialog.FileNames[i] + Environment.NewLine);
                cmd.ExecuteNonQuery();*/

            }
        }
        public void UpdatePlaylistName(string _name, int _ID)
        {
            using (var db = new DbContextModel())
            {
                Playlists UpdatePlaylistItem = db.Playlists.SingleOrDefault(i => i.ID == _ID);
                UpdatePlaylistItem.Name = _name;
                db.SaveChanges();
            }
               /* con.Open();

            SqlCommand cmd = new SqlCommand($"update Playlists set Playlist = '{_name}' where PlayListID = '{_ID}'", con);
            cmd.ExecuteNonQuery();
            con.Close();*/
        }
        public void AddSongsToPlayList(int _playListID, List<string> _url)
        {
           // con.Open();

            foreach (int item in GetSongIdsByName(_url))
            {
                using (var db = new DbContextModel())
                {
                    var PListID = new PlaylistInhoud { Playlist_ID = _playListID};
                    db.PlaylistInhoud.Add(PListID);
                }
                    /*SqlCommand cmd = new SqlCommand($"insert into PlaylistContent values('{_playListID}', '{item}')");
                cmd.Connection = con;
                cmd.ExecuteNonQuery()*/;
            }
           // con.Close();
        }
        public List<int> GetSongIdsByName(List<string> _url)
        {
            List<int> songs = new List<int>();
            foreach (string item in _url)
            {
                using (var db = new DbContextModel())
                {
                    Nummers nummer = db.Nummers.Where(n => n.Path == item).SingleOrDefault();
                    songs.Add(nummer.ID);
                }

                /*SqlCommand cmd = new SqlCommand($"select songID from XD where Path Like '%{item}%'");
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var peepee = reader.GetInt32(0);
                        songs.Add(peepee);

                    }
                }*/

            }

            return songs;

        }
        public void DeleteSongFromPlatlist(List<int> _url)
        {
            //con.Open();
            foreach (var item in _url)
            {
                using (var db = new DbContextModel())
                {
                    PlaylistInhoud DelteNummerItem = db.PlaylistInhoud.SingleOrDefault(i => i.Nummer_ID == item);
                    if (DelteNummerItem != null)
                    {
                        db.PlaylistInhoud.Remove(DelteNummerItem);
                        db.SaveChanges();
                    }
                }
                /*SqlCommand cmd = new SqlCommand($"delete from PlaylistContent where songID = '{item}' ");
                cmd.Connection = con;
                cmd.ExecuteNonQuery();*/
            }
            //con.Close();

        }
        public void DeletePlaylist(int _PlaylistId)
        {
            using (var db = new DbContextModel())
            {
                PlaylistInhoud DeltePlaylistItem = db.PlaylistInhoud.SingleOrDefault(i => i.Playlist_ID == _PlaylistId);
                if (DeltePlaylistItem != null)
                {
                    db.PlaylistInhoud.Remove(DeltePlaylistItem);
                    db.SaveChanges();
                }
                Playlists DeletePlaylist = db.Playlists.SingleOrDefault(i => i.ID == _PlaylistId);
                if (DeletePlaylist != null)
                {
                    db.Playlists.Remove(DeletePlaylist);
                    db.SaveChanges();
                }
            }
            /*con.Open();
            SqlCommand cmd = new SqlCommand($"delete from PlaylistContent where playlistID = '{_PlaylistId}' ");
            cmd.Connection = con;
            cmd.ExecuteNonQuery();


            SqlCommand cmd2 = new SqlCommand($"delete from Playlists where playlistID = '{_PlaylistId}' ");
            cmd2.Connection = con;
            cmd2.ExecuteNonQuery();
            con.Close();*/
        }
        public int GetPlaylistIDByName(string _name)
        {
            int Id = 0;
            using (var db = new DbContextModel())
            {
                Playlists playlist = db.Playlists.Where(n => n.Name == _name).SingleOrDefault();
                Id = playlist.ID;
            }

            /*CreateConnection();
            con.Open();
            int Id=0;
            SqlCommand cmd = new SqlCommand($"select playlistID from Playlists where Playlist='{_name}';");
            cmd.Connection = con;
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Id = dr.GetInt32(0);
            }
            con.Close();*/
            return Id;
            /*using (SqlDataReader reader = cmd.ExecuteReader())
            {
                
                    

                
            }*/




        }
    }
}
